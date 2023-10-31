using PodTubeEditor.Shared.Model;

namespace PodTubeEditor.Client.Services {
    public class TimelineService {
        public Timeline Timeline { get; set; } = new Timeline();

        public void AddAssetToTimeline(Asset asset) {
            if (asset.IsAudio) {
                Timeline.AudioItems.Add(new TimelineItem {
                    Asset = asset,
                    Duration = 100
                });
            } else {
                Timeline.VisualItems.Add(new TimelineItem {
                    Asset = asset,
                    Duration = 100
                });
            }
        }
    }
}
