using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002183")]
public class UILinkActivityPirateMapController : UILinkActivityDetailController
{
	[Token(Token = "0x400D232")]
	[FieldOffset(Offset = "0x34")]
	private UILinkActivityPirateMapView m_View;

	[Token(Token = "0x400D233")]
	[FieldOffset(Offset = "0x38")]
	private List<UILinkActivityPirateMapRewardItemController> m_DailyAwardControllers;

	[Token(Token = "0x600B1C4")]
	[Address(RVA = "0x25586BC", Offset = "0x25586BC", VA = "0x25586BC")]
	public UILinkActivityPirateMapController()
	{
	}

	[Token(Token = "0x600B1C5")]
	[Address(RVA = "0x25586C0", Offset = "0x25586C0", VA = "0x25586C0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B1C6")]
	[Address(RVA = "0x2558768", Offset = "0x2558768", VA = "0x2558768", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B1C7")]
	[Address(RVA = "0x2558904", Offset = "0x2558904", VA = "0x2558904", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600B1C8")]
	[Address(RVA = "0x255899C", Offset = "0x255899C", VA = "0x255899C", Slot = "33")]
	protected override void InitActivityInfo()
	{
	}

	[Token(Token = "0x600B1C9")]
	[Address(RVA = "0x2558D20", Offset = "0x2558D20", VA = "0x2558D20")]
	private void InitActivityInfo(LinkActivityData data)
	{
	}

	[Token(Token = "0x600B1CA")]
	[Address(RVA = "0x2559174", Offset = "0x2559174", VA = "0x2559174")]
	private void InitPirateInfo(LinkActivityMapData data)
	{
	}

	[Token(Token = "0x600B1CB")]
	[Address(RVA = "0x25592D4", Offset = "0x25592D4", VA = "0x25592D4")]
	private void _003CInitActivityInfo_003Em__0(Texture tex)
	{
	}

	[Token(Token = "0x600B1CC")]
	[Address(RVA = "0x25593D8", Offset = "0x25593D8", VA = "0x25593D8")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600B1CD")]
	[Address(RVA = "0x25593DC", Offset = "0x25593DC", VA = "0x25593DC")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
