using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;
namespace YTDownloader.classes {
    class Downloader {
        public static async Task Download(string url, string path) {

            var youtube = new YoutubeClient();

            try {
                var streamManifest = await youtube.Videos.Streams.GetManifestAsync(url);

                var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();

                await youtube.Videos.Streams.DownloadAsync(streamInfo, $"video.{streamInfo.Container}");

                var stream = await youtube.Videos.Streams.GetAsync(streamInfo);

                if (string.IsNullOrEmpty(path)) {
                    MessageBox.Show("Caminho Inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string outputFilePath = Path.Combine(path, $"video.{streamInfo.Container}");

                using (var output = File.OpenWrite(outputFilePath)) {
                    await stream.CopyToAsync(output);
                }


                MessageBox.Show("Sucesso", "Video baixado com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e) {
                MessageBox.Show("Ocorreu um erro ao fazer o download\n" +
                $"{e.ToString()}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }

}