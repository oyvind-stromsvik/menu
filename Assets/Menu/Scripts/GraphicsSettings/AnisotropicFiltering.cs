namespace TwiiksMenu {
    public class AnisotropicFiltering : SliderBase {

        protected override void GraphicsPresetLow() {
            Value = System.Convert.ToInt16(false);
        }

        protected override void GraphicsPresetMedium() {
            Value = System.Convert.ToInt16(true);
        }

        protected override void GraphicsPresetHigh() {
            Value = System.Convert.ToInt16(true);
        }

        protected override void GraphicsPresetUltra() {
            Value = System.Convert.ToInt16(true);
        }

        protected override void OnSliderValueChange() {
            SetAnisotropicFiltering(System.Convert.ToBoolean(Value));
        }

        void SetAnisotropicFiltering(bool value) {
            if (value) {
                UnityEngine.QualitySettings.anisotropicFiltering = UnityEngine.AnisotropicFiltering.ForceEnable;
            }
            else {
                UnityEngine.QualitySettings.anisotropicFiltering = UnityEngine.AnisotropicFiltering.Disable;
            }
        }
    }
}
