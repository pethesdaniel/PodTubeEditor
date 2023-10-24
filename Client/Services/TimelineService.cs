using PodTubeEditor.Shared.Model;

namespace PodTubeEditor.Client.Services {
    public class TimelineService {
        public Timeline Timeline { get; set; } = new Timeline();

        public void AddAssetToTimeline(Asset asset) {
            Timeline.Items.Add(new TimelineItem {
                Asset = asset,
                Duration = 100
            });
        }
    }
}
