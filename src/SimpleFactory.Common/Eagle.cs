namespace SimpleFactory.Common
{
    public class Eagle : IBird
    {
        public string Name { get; set; } = "老鷹";

        public void Fly()
        {
            // 實作可以飛高空
        }
    }
}