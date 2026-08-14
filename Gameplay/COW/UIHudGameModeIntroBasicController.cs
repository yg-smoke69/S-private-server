using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002758")]
public class UIHudGameModeIntroBasicController : UIBaseController
{
	[Token(Token = "0x2002759")]
	private sealed class _003CShowDetailInfo_003Ec__AnonStorey0
	{
		[Token(Token = "0x400F2F1")]
		[FieldOffset(Offset = "0x8")]
		internal Action callback;

		[Token(Token = "0x400F2F2")]
		[FieldOffset(Offset = "0xC")]
		internal UIHudGameModeIntroBasicController _0024this;

		[Token(Token = "0x600F066")]
		[Address(RVA = "0x18889FC", Offset = "0x18889FC", VA = "0x18889FC")]
		public _003CShowDetailInfo_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600F067")]
		[Address(RVA = "0x1888A0C", Offset = "0x1888A0C", VA = "0x1888A0C")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x400F2F0")]
	[FieldOffset(Offset = "0x28")]
	private UIHudGameModeIntroBasicView m_View;

	[Token(Token = "0x600F061")]
	[Address(RVA = "0x18881F8", Offset = "0x18881F8", VA = "0x18881F8")]
	public UIHudGameModeIntroBasicController()
	{
	}

	[Token(Token = "0x600F062")]
	[Address(RVA = "0x188827C", Offset = "0x188827C", VA = "0x188827C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F063")]
	[Address(RVA = "0x1888320", Offset = "0x1888320", VA = "0x1888320", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F064")]
	[Address(RVA = "0x1888414", Offset = "0x1888414", VA = "0x1888414")]
	public void ShowDetailInfo(GameModeIntroBasicInfo info, [Optional] Action callback)
	{
	}

	[Token(Token = "0x600F065")]
	[Address(RVA = "0x1888A04", Offset = "0x1888A04", VA = "0x1888A04")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
