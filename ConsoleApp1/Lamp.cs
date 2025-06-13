namespace ConsoleApp1
{
    public class Lamp : IDevice
    {
        private State state;

        public Lamp(State initialState)
        {
            this.state = initialState;
        }

        public void Operate()
        {
            state = state == State.On ? State.Off : State.On;
            Console.WriteLine("Luz " + (state == State.On ? "Ligada" : "Desligada"));
        }
    }
}
