using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading;

using ETHotfix;

namespace ETModel
{
    [ObjectSystem]
    public class RoleInfoComponentSystem : AwakeSystem<RoleInfoComponent>
    {
        public override void Awake(RoleInfoComponent self)
        {
            self.AwakeAsync();
        }

    }
    public class RoleInfoComponent : Component
    {
        public DBProxyComponent dbProxyComponent;
        public readonly Dictionary<long, RoleInfo> mOnlineUserDic = new Dictionary<long, RoleInfo>();
        public static RoleInfoComponent Ins { private set; get; }
        public async ETTask AwakeAsync()
        {
            Ins = this;
            dbProxyComponent = Game.Scene.GetComponent<DBProxyComponent>();


            //var roleInfo = new RoleInfo();
            //roleInfo.Id = InstanceId;
            //await dbProxyComponent.Save(roleInfo);
        }

        public async ETTask CheckAndCreateRoleInfo(RoleInfo roleInfo)
        {
            List<ComponentWithId> ls = await dbProxyComponent.Query<RoleInfo>(info => info.Name == roleInfo.Name);
            if (ls.Count <= 0)
            {
                await dbProxyComponent.Save(roleInfo);
            }
        }



    }

}
