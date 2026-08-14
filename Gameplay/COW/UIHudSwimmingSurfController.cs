using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002863")]
internal class UIHudSwimmingSurfController : UIHudButtonBaseController
{
	[Token(Token = "0x400F91E")]
	[FieldOffset(Offset = "0x2C")]
	private UIHudSwimmingSurfView m_View;

	[Token(Token = "0x400F91F")]
	private const string SpriteWaterSurfing = "SG_UI_icon_WaterSurfing";

	[Token(Token = "0x400F920")]
	private const string SpriteWaterSurfingHighlight = "SG_UI_icon_WaterSurfing_Choose";

	[Token(Token = "0x400F921")]
	[FieldOffset(Offset = "0x30")]
	private bool mIsHighlight;

	[Token(Token = "0x600FCD1")]
	[Address(RVA = "0x1FF0FFC", Offset = "0x1FF0FFC", VA = "0x1FF0FFC")]
	public UIHudSwimmingSurfController()
	{
	}

	[Token(Token = "0x600FCD2")]
	[Address(RVA = "0x1FF1004", Offset = "0x1FF1004", VA = "0x1FF1004")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FCD3")]
	[Address(RVA = "0x1FF10A8", Offset = "0x1FF10A8", VA = "0x1FF10A8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FCD4")]
	[Address(RVA = "0x1FF1274", Offset = "0x1FF1274", VA = "0x1FF1274", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600FCD5")]
	[Address(RVA = "0x1FF13A8", Offset = "0x1FF13A8", VA = "0x1FF13A8", Slot = "36")]
	protected override string GetMappingName()
	{
		return null;
	}

	[Token(Token = "0x600FCD6")]
	[Address(RVA = "0x1FF144C", Offset = "0x1FF144C", VA = "0x1FF144C")]
	private void Update()
	{
	}

	[Token(Token = "0x600FCD7")]
	[Address(RVA = "0x1FF16D0", Offset = "0x1FF16D0", VA = "0x1FF16D0")]
	private void OnShowSwimmingSurfHud(object[] param)
	{
	}

	[Token(Token = "0x600FCD8")]
	[Address(RVA = "0x1FF1584", Offset = "0x1FF1584", VA = "0x1FF1584")]
	private void SetHighLight(bool highlight)
	{
	}

	[Token(Token = "0x600FCD9")]
	[Address(RVA = "0x1FF17DC", Offset = "0x1FF17DC", VA = "0x1FF17DC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600FCDA")]
	[Address(RVA = "0x1FF17E4", Offset = "0x1FF17E4", VA = "0x1FF17E4")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
