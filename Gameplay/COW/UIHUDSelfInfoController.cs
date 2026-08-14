using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002C3B")]
public class UIHUDSelfInfoController : UIBaseController
{
	[Token(Token = "0x4010DE8")]
	[FieldOffset(Offset = "0x28")]
	private UIHUDWereWolvesSelfInfoView m_View;

	[Token(Token = "0x60126F5")]
	[Address(RVA = "0x220F354", Offset = "0x220F354", VA = "0x220F354")]
	public UIHUDSelfInfoController()
	{
	}

	[Token(Token = "0x60126F6")]
	[Address(RVA = "0x220F3D8", Offset = "0x220F3D8", VA = "0x220F3D8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60126F7")]
	[Address(RVA = "0x220F480", Offset = "0x220F480", VA = "0x220F480", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60126F8")]
	[Address(RVA = "0x220F53C", Offset = "0x220F53C", VA = "0x220F53C")]
	public void SetNameInfo(string info, Color color)
	{
	}

	[Token(Token = "0x60126F9")]
	[Address(RVA = "0x220F650", Offset = "0x220F650", VA = "0x220F650")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
