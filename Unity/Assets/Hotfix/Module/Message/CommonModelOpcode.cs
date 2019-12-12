using ETModel;
namespace ETHotfix
{
	[Message(CommonModelOpcode.RoleInfo)]
	public partial class RoleInfo {}

}
namespace ETHotfix
{
	public static partial class CommonModelOpcode
	{
		 public const ushort RoleInfo = 20001;
	}
}
