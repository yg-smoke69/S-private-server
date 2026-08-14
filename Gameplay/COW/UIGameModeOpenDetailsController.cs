using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20026AD")]
internal class UIGameModeOpenDetailsController : UIBaseController
{
	[Token(Token = "0x400EEB3")]
	[FieldOffset(Offset = "0x28")]
	private UIGameModeOpenDetailsView m_View;

	[Token(Token = "0x400EEB4")]
	[FieldOffset(Offset = "0x2C")]
	private Vector3 m_DefaultOpenPos;

	[Token(Token = "0x400EEB5")]
	[FieldOffset(Offset = "0x38")]
	private MapModeData m_SelectedMapData;

	[Token(Token = "0x400EEB6")]
	[FieldOffset(Offset = "0x3C")]
	private UIModelMapOpeningInfo m_ModelMap;

	[Token(Token = "0x600E90B")]
	[Address(RVA = "0x218B804", Offset = "0x218B804", VA = "0x218B804")]
	public UIGameModeOpenDetailsController()
	{
	}

	[Token(Token = "0x600E90C")]
	[Address(RVA = "0x218B888", Offset = "0x218B888", VA = "0x218B888", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600E90D")]
	[Address(RVA = "0x218B8EC", Offset = "0x218B8EC", VA = "0x218B8EC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E90E")]
	[Address(RVA = "0x218BB1C", Offset = "0x218BB1C", VA = "0x218BB1C", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600E90F")]
	[Address(RVA = "0x218BC50", Offset = "0x218BC50", VA = "0x218BC50")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E910")]
	[Address(RVA = "0x218BCF8", Offset = "0x218BCF8", VA = "0x218BCF8", Slot = "30")]
	protected override ResourceID GetResID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E911")]
	[Address(RVA = "0x218BD54", Offset = "0x218BD54", VA = "0x218BD54")]
	public void SetUIData(MapModeData mapModeData)
	{
	}

	[Token(Token = "0x600E912")]
	[Address(RVA = "0x218BEA0", Offset = "0x218BEA0", VA = "0x218BEA0")]
	private Color GetTagColor(EMapTag tag)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Color);
	}

	[Token(Token = "0x600E913")]
	[Address(RVA = "0x218BF40", Offset = "0x218BF40", VA = "0x218BF40")]
	public void SetOpenTimeUI(object[] data)
	{
	}

	[Token(Token = "0x600E914")]
	[Address(RVA = "0x218C298", Offset = "0x218C298", VA = "0x218C298")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600E915")]
	[Address(RVA = "0x218C2A0", Offset = "0x218C2A0", VA = "0x218C2A0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E916")]
	[Address(RVA = "0x218C2A8", Offset = "0x218C2A8", VA = "0x218C2A8")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x600E917")]
	[Address(RVA = "0x218C2B0", Offset = "0x218C2B0", VA = "0x218C2B0")]
	public ResourceID _003C_003EiFixBaseProxy_GetResID()
	{
		return default(ResourceID);
	}
}
