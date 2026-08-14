using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200286F")]
internal class UIHudTeamScoreNotificationController : UIHudKillNotificationBaseController
{
	[Token(Token = "0x400F94C")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Dictionary<int, uint> HYPELEVEL_COLOR;

	[Token(Token = "0x400F94D")]
	[FieldOffset(Offset = "0x4")]
	private static readonly uint DEFAULT_COLOR;

	[Token(Token = "0x400F94E")]
	[FieldOffset(Offset = "0x30")]
	private UIHudTeamScoreNotificationView m_View;

	[Token(Token = "0x600FD8E")]
	[Address(RVA = "0x179CB94", Offset = "0x179CB94", VA = "0x179CB94")]
	public UIHudTeamScoreNotificationController()
	{
	}

	[Token(Token = "0x600FD8F")]
	[Address(RVA = "0x179CB9C", Offset = "0x179CB9C", VA = "0x179CB9C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FD90")]
	[Address(RVA = "0x179CC40", Offset = "0x179CC40", VA = "0x179CC40", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FD91")]
	[Address(RVA = "0x179CCFC", Offset = "0x179CCFC", VA = "0x179CCFC", Slot = "33")]
	protected override void OnKill(Player killer, Player beKiller, object[] param)
	{
	}

	[Token(Token = "0x600FD93")]
	[Address(RVA = "0x179D32C", Offset = "0x179D32C", VA = "0x179D32C")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
