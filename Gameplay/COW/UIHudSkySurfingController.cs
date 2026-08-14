using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002854")]
internal class UIHudSkySurfingController : UIHudButtonBaseController
{
	[Token(Token = "0x400F8CA")]
	[FieldOffset(Offset = "0x2C")]
	private UIHudSkySurfingView m_View;

	[Token(Token = "0x400F8CB")]
	[FieldOffset(Offset = "0x30")]
	private bool m_IsHighlight;

	[Token(Token = "0x400F8CC")]
	private const string m_SkySurfingIcon = "SG_UI_icon_SkydivingStance";

	[Token(Token = "0x400F8CD")]
	private const string m_SkySurfingIconHighLight = "SG_UI_icon_SkydivingStance_choose";

	[Token(Token = "0x400F8CE")]
	private const string m_SkyFlightSurfingIcon = "SG_UI_icon_Mounts_Dive";

	[Token(Token = "0x400F8CF")]
	private const string m_SkyFlightSurfingIconHighLight = "SG_UI_icon_Mounts_Dive_Choose";

	[Token(Token = "0x600FC33")]
	[Address(RVA = "0x16CE2A0", Offset = "0x16CE2A0", VA = "0x16CE2A0")]
	public UIHudSkySurfingController()
	{
	}

	[Token(Token = "0x600FC34")]
	[Address(RVA = "0x16CE2A8", Offset = "0x16CE2A8", VA = "0x16CE2A8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FC35")]
	[Address(RVA = "0x16CE34C", Offset = "0x16CE34C", VA = "0x16CE34C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FC36")]
	[Address(RVA = "0x16CE6D8", Offset = "0x16CE6D8", VA = "0x16CE6D8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600FC37")]
	[Address(RVA = "0x16CE944", Offset = "0x16CE944", VA = "0x16CE944", Slot = "36")]
	protected override string GetMappingName()
	{
		return null;
	}

	[Token(Token = "0x600FC38")]
	[Address(RVA = "0x16CE9E8", Offset = "0x16CE9E8", VA = "0x16CE9E8")]
	private void Update()
	{
	}

	[Token(Token = "0x600FC39")]
	[Address(RVA = "0x16CEB88", Offset = "0x16CEB88", VA = "0x16CEB88")]
	private void SetHightlight(bool highlight, bool haveFlilght)
	{
	}

	[Token(Token = "0x600FC3A")]
	[Address(RVA = "0x16CECD0", Offset = "0x16CECD0", VA = "0x16CECD0")]
	private void OnStopSkySurfing(object[] param)
	{
	}

	[Token(Token = "0x600FC3B")]
	[Address(RVA = "0x16CED60", Offset = "0x16CED60", VA = "0x16CED60")]
	private void OnStartSkyDiving(object[] param)
	{
	}

	[Token(Token = "0x600FC3C")]
	[Address(RVA = "0x16CF008", Offset = "0x16CF008", VA = "0x16CF008")]
	private void OnShowSurfingTutorial(object[] param)
	{
	}

	[Token(Token = "0x600FC3D")]
	[Address(RVA = "0x16CF164", Offset = "0x16CF164", VA = "0x16CF164")]
	private void OnLocalPlayerTeamParachuteModeChange(object[] param)
	{
	}

	[Token(Token = "0x600FC3E")]
	[Address(RVA = "0x16CF330", Offset = "0x16CF330", VA = "0x16CF330")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600FC3F")]
	[Address(RVA = "0x16CF338", Offset = "0x16CF338", VA = "0x16CF338")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
