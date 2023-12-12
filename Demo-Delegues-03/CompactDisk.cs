namespace Demo_Delegues_03
{
    internal class CompactDisk
    {
        public int[] TimeTracks { get; private set; }

        public CompactDisk(int[] times)
        {
            TimeTracks = times;
        }
    }
}