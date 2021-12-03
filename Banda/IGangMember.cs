namespace Banda
{
    interface IGangMember
    {
        IRingleader _ringleader { get; set; }
        string Name { get; set; }
        
         
        void Ready(IRingleader ringleader);
    }
}
