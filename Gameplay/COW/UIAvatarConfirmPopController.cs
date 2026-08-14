using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20024A3")]
public class UIAvatarConfirmPopController : UIPopupWindowController
{
	[Token(Token = "0x400E304")]
	[FieldOffset(Offset = "0x48")]
	private UIAvatarConfirmPopView m_View;

	[Token(Token = "0x400E305")]
	[FieldOffset(Offset = "0x4C")]
	private int m_num1;

	[Token(Token = "0x400E306")]
	[FieldOffset(Offset = "0x50")]
	private int m_num2;

	[Token(Token = "0x400E307")]
	[FieldOffset(Offset = "0x54")]
	private uint m_AvatarId;

	[Token(Token = "0x400E308")]
	[FieldOffset(Offset = "0x58")]
	private uint buyid;

	[Token(Token = "0x400E309")]
	[FieldOffset(Offset = "0x5C")]
	private uint m_Interval;

	[Token(Token = "0x400E30A")]
	[FieldOffset(Offset = "0x60")]
	private uint m_PriceGem;

	[Token(Token = "0x400E30B")]
	[FieldOffset(Offset = "0x64")]
	private uint m_PriceGold;

	[Token(Token = "0x400E30C")]
	[FieldOffset(Offset = "0x68")]
	private uint m_GoldCnt;

	[Token(Token = "0x400E30D")]
	[FieldOffset(Offset = "0x6C")]
	private uint m_GemCnt;

	[Token(Token = "0x400E30E")]
	[FieldOffset(Offset = "0x70")]
	private uint m_DebrisId;

	[Token(Token = "0x400E30F")]
	[FieldOffset(Offset = "0x74")]
	private UIModelMall m_ModelMall;

	[Token(Token = "0x400E310")]
	[FieldOffset(Offset = "0x78")]
	private UIStandardItemMAXBController m_StandradCtrl;

	[Token(Token = "0x600D19A")]
	[Address(RVA = "0x1E8A210", Offset = "0x1E8A210", VA = "0x1E8A210")]
	public UIAvatarConfirmPopController()
	{
	}

	[Token(Token = "0x600D19B")]
	[Address(RVA = "0x1E8A224", Offset = "0x1E8A224", VA = "0x1E8A224")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D19C")]
	[Address(RVA = "0x1E8A2CC", Offset = "0x1E8A2CC", VA = "0x1E8A2CC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D19D")]
	[Address(RVA = "0x1E8A8DC", Offset = "0x1E8A8DC", VA = "0x1E8A8DC")]
	public void InitClosedBtn()
	{
	}

	[Token(Token = "0x600D19E")]
	[Address(RVA = "0x1E8AAAC", Offset = "0x1E8AAAC", VA = "0x1E8AAAC")]
	private void OnMyClose()
	{
	}

	[Token(Token = "0x600D19F")]
	[Address(RVA = "0x1E8AC20", Offset = "0x1E8AC20", VA = "0x1E8AC20")]
	private void OnGoldBuy()
	{
	}

	[Token(Token = "0x600D1A0")]
	[Address(RVA = "0x1E8B0C0", Offset = "0x1E8B0C0", VA = "0x1E8B0C0")]
	private void OnGemBuy()
	{
	}

	[Token(Token = "0x600D1A1")]
	[Address(RVA = "0x1E8B4E4", Offset = "0x1E8B4E4", VA = "0x1E8B4E4")]
	private void OnLevelUp()
	{
	}

	[Token(Token = "0x600D1A2")]
	[Address(RVA = "0x1E8B630", Offset = "0x1E8B630", VA = "0x1E8B630", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600D1A3")]
	[Address(RVA = "0x1E8B764", Offset = "0x1E8B764", VA = "0x1E8B764")]
	private void OnUpdateInfo(object[] data)
	{
	}

	[Token(Token = "0x600D1A4")]
	[Address(RVA = "0x1E8B7C0", Offset = "0x1E8B7C0", VA = "0x1E8B7C0")]
	public void RefreshData(uint avatarid, int num1, int num2, uint debrisid)
	{
	}

	[Token(Token = "0x600D1A5")]
	[Address(RVA = "0x1E8B938", Offset = "0x1E8B938", VA = "0x1E8B938")]
	private void RefreshInfo()
	{
	}

	[Token(Token = "0x600D1A6")]
	[Address(RVA = "0x1E8C31C", Offset = "0x1E8C31C", VA = "0x1E8C31C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D1A7")]
	[Address(RVA = "0x1E8C324", Offset = "0x1E8C324", VA = "0x1E8C324")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
