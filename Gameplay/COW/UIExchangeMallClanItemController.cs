using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20021B1")]
public class UIExchangeMallClanItemController : UIExchangeMallItemController
{
	[Token(Token = "0x400D2FC")]
	[FieldOffset(Offset = "0x134")]
	private bool m_IsReachClanLevel;

	[Token(Token = "0x400D2FD")]
	[FieldOffset(Offset = "0x138")]
	private uint m_MyClanLevel;

	[Token(Token = "0x600B36F")]
	[Address(RVA = "0x19DD758", Offset = "0x19DD758", VA = "0x19DD758")]
	public UIExchangeMallClanItemController()
	{
	}

	[Token(Token = "0x600B370")]
	[Address(RVA = "0x19DD768", Offset = "0x19DD768", VA = "0x19DD768", Slot = "30")]
	protected override ResourceID GetResID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B371")]
	[Address(RVA = "0x19DD7C4", Offset = "0x19DD7C4", VA = "0x19DD7C4")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B372")]
	[Address(RVA = "0x19DD868", Offset = "0x19DD868", VA = "0x19DD868", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B373")]
	[Address(RVA = "0x19DDA94", Offset = "0x19DDA94", VA = "0x19DDA94", Slot = "43")]
	protected override void ResetState()
	{
	}

	[Token(Token = "0x600B374")]
	[Address(RVA = "0x19DDBEC", Offset = "0x19DDBEC", VA = "0x19DDBEC", Slot = "42")]
	protected override void RefreshItemView()
	{
	}

	[Token(Token = "0x600B375")]
	[Address(RVA = "0x19DE48C", Offset = "0x19DE48C", VA = "0x19DE48C", Slot = "47")]
	public override void RefreshItemBGState()
	{
	}

	[Token(Token = "0x600B376")]
	[Address(RVA = "0x19DE5C0", Offset = "0x19DE5C0", VA = "0x19DE5C0")]
	private void SetComposeIconColor(UISprite boxSprite, Color color)
	{
	}

	[Token(Token = "0x600B377")]
	[Address(RVA = "0x19DDD9C", Offset = "0x19DDD9C", VA = "0x19DDD9C")]
	private void CheckIsReachClanLevel()
	{
	}

	[Token(Token = "0x600B378")]
	[Address(RVA = "0x19DE120", Offset = "0x19DE120", VA = "0x19DE120")]
	private void RefreshClanLevelTitle()
	{
	}

	[Token(Token = "0x600B379")]
	[Address(RVA = "0x19DE77C", Offset = "0x19DE77C", VA = "0x19DE77C")]
	public new ResourceID _003C_003EiFixBaseProxy_GetResID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B37A")]
	[Address(RVA = "0x19DE7DC", Offset = "0x19DE7DC", VA = "0x19DE7DC")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600B37B")]
	[Address(RVA = "0x19DE7E4", Offset = "0x19DE7E4", VA = "0x19DE7E4")]
	public new void _003C_003EiFixBaseProxy_ResetState()
	{
	}

	[Token(Token = "0x600B37C")]
	[Address(RVA = "0x19DE7E8", Offset = "0x19DE7E8", VA = "0x19DE7E8")]
	public new void _003C_003EiFixBaseProxy_RefreshItemView()
	{
	}

	[Token(Token = "0x600B37D")]
	[Address(RVA = "0x19DE7EC", Offset = "0x19DE7EC", VA = "0x19DE7EC")]
	public void _003C_003EiFixBaseProxy_RefreshItemBGState()
	{
	}
}
