using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JYoutube.Lib.Youtube
{
    class Playlists
    {
        private string playlist_name = "";
        private string playlist_id = "";
        private string play_id = "";

        public static int finish = 0;

        public Playlists(string jPlaylist_name, string jPlaylist_id, string jPlay_id)
        {
            playlist_name = jPlaylist_name;
            playlist_id = jPlaylist_id;
            play_id = jPlay_id;
        }

        public static void Start(string jPlaylist_name, string jPlaylist_id, string jPlay_id)
        {
            try
            {
                new Playlists(jPlaylist_name, jPlaylist_id, jPlay_id).Run().Wait();
                finish = 1;
            }
            catch (AggregateException ex)
            {
                foreach (var e in ex.InnerExceptions)
                {
                    jThread.insertLog("更新视频播放列表失败: " + e.Message);
                    //Console.WriteLine("Error: " + e.Message);
                }
                finish = -1;
            }
        }

        private async Task Run()
        {
            UserCredential credential;
            using (var stream = new FileStream("client_secrets.json", FileMode.Open, FileAccess.Read))
            {
                credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    new[] { YouTubeService.Scope.Youtube },
                    "user",
                    CancellationToken.None,
                    new FileDataStore(this.GetType().ToString())
                );
            }

            var youtubeService = new YouTubeService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = this.GetType().ToString()
            });

            var newPlaylist = new Playlist();
            //查找playlist
            var playlists_search = youtubeService.Playlists.List("snippet");
            playlists_search.Id = playlist_id;
            var playListResponse = playlists_search.ExecuteAsync().Result;
            if (playListResponse.Items.Count > 0)
            {
                newPlaylist = playListResponse.Items[0];
            }
            else
            {
                //创建playlist
                newPlaylist.Snippet = new PlaylistSnippet();
                newPlaylist.Snippet.Title = playlist_name;
                newPlaylist.Snippet.Description = playlist_name;
                newPlaylist.Status = new PlaylistStatus();
                newPlaylist.Status.PrivacyStatus = "public";
                newPlaylist = await youtubeService.Playlists.Insert(newPlaylist, "snippet,status").ExecuteAsync();
            }
            //添加视频
            var newPlaylistItem = new PlaylistItem();
            newPlaylistItem.Snippet = new PlaylistItemSnippet();
            newPlaylistItem.Snippet.PlaylistId = newPlaylist.Id;
            newPlaylistItem.Snippet.ResourceId = new ResourceId();
            newPlaylistItem.Snippet.ResourceId.Kind = "youtube#video";
            newPlaylistItem.Snippet.ResourceId.VideoId = play_id;
            newPlaylistItem = await youtubeService.PlaylistItems.Insert(newPlaylistItem, "snippet").ExecuteAsync();

            jThread.insertLog("更新视频播放列表成功!");
            //Console.WriteLine("Playlist item id {0} was added to playlist id {1}.", newPlaylistItem.Id, newPlaylist.Id);
        }

    }
}
