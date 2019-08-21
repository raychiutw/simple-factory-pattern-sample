namespace SimpleFactory.Common
{
    public class Swan : IBird
    {
        public string Name { get; set; } = "天鵝";

        public void Fly()
        {
            // 實作只能飛低空
        }
    }
}