namespace Banda
{
    interface IRingleader
    {
        void AddToBand(IGangMember member);
        void RemoveFromBand(IGangMember member);
        void Notify();
        void BandaReady(IGangMember member);

        void Wasted();
    }
}
