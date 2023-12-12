namespace Demo_Delegues_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CDPlayer player = new CDPlayer();
            CompactDisk albumStromae = new CompactDisk(new int[] { 0, 180, 450, 600, 720 });

            player.PutCD(albumStromae);

            player.AddToProgram(1);
            player.AddToProgram(1);
            player.AddToProgram(5);
            player.AddToProgram(1);
            player.AddToProgram(3);
            player.AddToProgram(4);

            player.Play();
        }
    }
}
