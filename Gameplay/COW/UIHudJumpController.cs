using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200279A")]
internal class UIHudJumpController : UIHudButtonBaseController
{
	[Token(Token = "0x400F484")]
	[FieldOffset(Offset = "0x2C")]
	private UIHudJumpView m_View;

	[Token(Token = "0x400F485")]
	private const string m_JumpIcon = "SG_UI_icon_jump";

	[Token(Token = "0x400F486")]
	private const string m_HumanTireJumpIcon = "SG_UI_icon_humantire";

	[Token(Token = "0x400F487")]
	[FieldOffset(Offset = "0x30")]
	private bool m_Isfalling;

	[Token(Token = "0x400F488")]
	[FieldOffset(Offset = "0x34")]
	private Vector3 defatultpos;

	[Token(Token = "0x400F489")]
	[FieldOffset(Offset = "0x40")]
	private Vector3 climbpos;

	[Token(Token = "0x600F40A")]
	[Address(RVA = "0x20B28B4", Offset = "0x20B28B4", VA = "0x20B28B4")]
	public UIHudJumpController()
	{
	}

	[Token(Token = "0x600F40B")]
	[Address(RVA = "0x20B2948", Offset = "0x20B2948", VA = "0x20B2948")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F40C")]
	[Address(RVA = "0x20B29EC", Offset = "0x20B29EC", VA = "0x20B29EC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F40D")]
	[Address(RVA = "0x20B2DF8", Offset = "0x20B2DF8", VA = "0x20B2DF8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600F40E")]
	[Address(RVA = "0x20B3134", Offset = "0x20B3134", VA = "0x20B3134")]
	private void OnReadyToClimb(object[] data)
	{
	}

	[Token(Token = "0x600F40F")]
	[Address(RVA = "0x20B3610", Offset = "0x20B3610", VA = "0x20B3610")]
	private void ResetIconPos()
	{
	}

	[Token(Token = "0x600F410")]
	[Address(RVA = "0x20B36E4", Offset = "0x20B36E4", VA = "0x20B36E4")]
	private void OnReadyToGlide(object[] data)
	{
	}

	[Token(Token = "0x600F411")]
	[Address(RVA = "0x20B3A10", Offset = "0x20B3A10", VA = "0x20B3A10")]
	private void OnEquipJumpShoes(object[] data)
	{
	}

	[Token(Token = "0x600F412")]
	[Address(RVA = "0x20B3AA8", Offset = "0x20B3AA8", VA = "0x20B3AA8")]
	private void OnUnEquipJumpShoes(object[] data)
	{
	}

	[Token(Token = "0x600F413")]
	[Address(RVA = "0x20B3B40", Offset = "0x20B3B40", VA = "0x20B3B40")]
	private void OnEnergyChange(object[] data)
	{
	}

	[Token(Token = "0x600F414")]
	[Address(RVA = "0x20B3DB0", Offset = "0x20B3DB0", VA = "0x20B3DB0")]
	private void OnHumanTireJumpStateChange(object[] data)
	{
	}

	[Token(Token = "0x600F415")]
	[Address(RVA = "0x20B3FAC", Offset = "0x20B3FAC", VA = "0x20B3FAC", Slot = "36")]
	protected override string GetMappingName()
	{
		return null;
	}

	[Token(Token = "0x600F416")]
	[Address(RVA = "0x20B4050", Offset = "0x20B4050", VA = "0x20B4050")]
	private void Update()
	{
	}

	[Token(Token = "0x600F417")]
	[Address(RVA = "0x20B4188", Offset = "0x20B4188", VA = "0x20B4188")]
	private void SetHightlight(bool flag)
	{
	}

	[Token(Token = "0x600F418")]
	[Address(RVA = "0x20B4344", Offset = "0x20B4344", VA = "0x20B4344")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F419")]
	[Address(RVA = "0x20B434C", Offset = "0x20B434C", VA = "0x20B434C")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
