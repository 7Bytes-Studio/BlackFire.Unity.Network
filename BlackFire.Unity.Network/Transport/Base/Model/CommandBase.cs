//----------------------------------------------------
//Copyright © 2008-2017 Mr-Alan. All rights reserved.
//Mail: Mr.Alan.China@[outlook|gmail].com
//Website: www.0x69h.com
//----------------------------------------------------

namespace BlackFire.Unity.Network
{
    public abstract class CommandBase<TPackageInfo> : ICommand<TPackageInfo> where TPackageInfo : IPackageInfo
    {
        public abstract void ExecuteCommand(TransportBase transport, TPackageInfo packageInfo);
    }
}