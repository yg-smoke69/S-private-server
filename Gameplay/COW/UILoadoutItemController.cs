using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002913")]
internal class UILoadoutItemController : UIBaseController
{
	[Token(Token = "0x400FCF0")]
	[FieldOffset(Offset = "0x28")]
	private UILoadOutItemView m_View;

	[Token(Token = "0x400FCF1")]
	[FieldOffset(Offset = "0x2C")]
	public int ItemIdex;

	[Token(Token = "0x400FCF2")]
	[FieldOffset(Offset = "0x30")]
	public BaseItemInfo LoadOutData;

	[Token(Token = "0x400FCF3")]
	[FieldOffset(Offset = "0x34")]
	public Item PlayCardData;

	[Token(Token = "0x400FCF4")]
	[FieldOffset(Offset = "0x38")]
	public CSSharedItemDataManager.LoadoutSubType LoadOutType;

	[Token(Token = "0x400FCF5")]
	[FieldOffset(Offset = "0x3C")]
	public StoreDesc LoadoutStoreInfo;

	[Token(Token = "0x400FCF6")]
	[FieldOffset(Offset = "0x40")]
	public int BuyCount;

	[Token(Token = "0x400FCF7")]
	[FieldOffset(Offset = "0x44")]
	protected bool m_selected;

	[Token(Token = "0x400FCF8")]
	[FieldOffset(Offset = "0x48")]
	private TweenAlpha m_GuideAlpha;

	[Token(Token = "0x400FCF9")]
	[FieldOffset(Offset = "0x4C")]
	private UISprite m_HLSprite;

	[Token(Token = "0x400FCFA")]
	[FieldOffset(Offset = "0x50")]
	protected List<string> LoadoutTutorialTitles;

	[Token(Token = "0x601049B")]
	[Address(RVA = "0x2160018", Offset = "0x2160018", VA = "0x2160018")]
	public UILoadoutItemController()
	{
	}

	[Token(Token = "0x601049C")]
	[Address(RVA = "0x21600D0", Offset = "0x21600D0", VA = "0x21600D0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601049D")]
	[Address(RVA = "0x2160174", Offset = "0x2160174", VA = "0x2160174", Slot = "31")]
	public virtual UIWidget GetWidget()
	{
		return null;
	}

	[Token(Token = "0x601049E")]
	[Address(RVA = "0x21601E4", Offset = "0x21601E4", VA = "0x21601E4", Slot = "32")]
	public virtual UIButton GetButton()
	{
		return null;
	}

	[Token(Token = "0x601049F")]
	[Address(RVA = "0x2160254", Offset = "0x2160254", VA = "0x2160254", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60104A0")]
	[Address(RVA = "0x215EB80", Offset = "0x215EB80", VA = "0x215EB80")]
	public void ShowNewbieGuide(bool show)
	{
	}

	[Token(Token = "0x60104A1")]
	[Address(RVA = "0x216095C", Offset = "0x216095C", VA = "0x216095C")]
	private void OnInfoBtnClicked()
	{
	}

	[Token(Token = "0x60104A2")]
	[Address(RVA = "0x2160C4C", Offset = "0x2160C4C", VA = "0x2160C4C")]
	private void ToggleInfoText()
	{
	}

	[Token(Token = "0x60104A3")]
	[Address(RVA = "0x2160E88", Offset = "0x2160E88", VA = "0x2160E88")]
	private void OnIncreaseClicked()
	{
	}

	[Token(Token = "0x60104A4")]
	[Address(RVA = "0x21610A8", Offset = "0x21610A8", VA = "0x21610A8")]
	private void OnDecreaseClicked()
	{
	}

	[Token(Token = "0x60104A5")]
	[Address(RVA = "0x2160704", Offset = "0x2160704", VA = "0x2160704")]
	protected void ShowBuyInfo(bool val)
	{
	}

	[Token(Token = "0x60104A6")]
	[Address(RVA = "0x2160F68", Offset = "0x2160F68", VA = "0x2160F68")]
	private void RefreshBuyInfo()
	{
	}

	[Token(Token = "0x60104A7")]
	[Address(RVA = "0x2161188", Offset = "0x2161188", VA = "0x2161188")]
	private void OnBtnClicked()
	{
	}

	[Token(Token = "0x60104A8")]
	[Address(RVA = "0x2161670", Offset = "0x2161670", VA = "0x2161670")]
	public void SetData(BaseItemInfo item, int index)
	{
	}

	[Token(Token = "0x60104A9")]
	[Address(RVA = "0x21618E8", Offset = "0x21618E8", VA = "0x21618E8")]
	public void RefreshUI()
	{
	}

	[Token(Token = "0x60104AA")]
	[Address(RVA = "0x215F3C8", Offset = "0x215F3C8", VA = "0x215F3C8")]
	public void SetSelected(bool v)
	{
	}

	[Token(Token = "0x60104AB")]
	[Address(RVA = "0x2162344", Offset = "0x2162344", VA = "0x2162344")]
	private void OnBuyClick()
	{
	}

	[Token(Token = "0x60104AC")]
	[Address(RVA = "0x2162164", Offset = "0x2162164", VA = "0x2162164")]
	protected void RefreshPlayCardTime()
	{
	}

	[Token(Token = "0x60104AD")]
	[Address(RVA = "0x21608C4", Offset = "0x21608C4", VA = "0x21608C4")]
	protected void ShowPlayCardInfo(bool val)
	{
	}

	[Token(Token = "0x60104AE")]
	[Address(RVA = "0x21624AC", Offset = "0x21624AC", VA = "0x21624AC")]
	public void Update()
	{
	}

	[Token(Token = "0x60104AF")]
	[Address(RVA = "0x216262C", Offset = "0x216262C", VA = "0x216262C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
