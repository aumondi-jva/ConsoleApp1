namespace ConsoleApp1
{
    public class Switch
    {
        private IDevice device;

        public Switch(IDevice device)
        {
            this.device = device;
        }

        public void Press()
        {
            device.Operate();
        }
    }
}
