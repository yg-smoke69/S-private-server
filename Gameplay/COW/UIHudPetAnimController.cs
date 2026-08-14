using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20027F0")]
internal class UIHudPetAnimController : UIBaseController
{
	[Token(Token = "0x20027F1")]
	private sealed class _003CInitBtn_003Ec__AnonStorey0
	{
		[Token(Token = "0x400F67C")]
		[FieldOffset(Offset = "0x8")]
		internal PetActionData d;

		[Token(Token = "0x400F67D")]
		[FieldOffset(Offset = "0xC")]
		internal int slotId;

		[Token(Token = "0x400F67E")]
		[FieldOffset(Offset = "0x10")]
		internal UIHudPetAnimController _0024this;

		[Token(Token = "0x600F7F9")]
		[Address(RVA = "0x1848D74", Offset = "0x1848D74", VA = "0x1848D74")]
		public _003CInitBtn_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600F7FA")]
		[Address(RVA = "0x1849E7C", Offset = "0x1849E7C", VA = "0x1849E7C")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x400F676")]
	[FieldOffset(Offset = "0x28")]
	private UIHudPetAnimView m_View;

	[Token(Token = "0x400F677")]
	[FieldOffset(Offset = "0x2C")]
	private NetworkPet m_Pet;

	[Token(Token = "0x400F678")]
	[FieldOffset(Offset = "0x30")]
	private bool m_HidePet;

	[Token(Token = "0x400F679")]
	[FieldOffset(Offset = "0x31")]
	private bool m_NeedDownload;

	[Token(Token = "0x400F67A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int PetPanelTotalCount;

	[Token(Token = "0x400F67B")]
	[FieldOffset(Offset = "0x34")]
	private GameObject[] m_Desgars;

	[Token(Token = "0x600F7E5")]
	[Address(RVA = "0x184748C", Offset = "0x184748C", VA = "0x184748C")]
	public UIHudPetAnimController()
	{
	}

	[Token(Token = "0x600F7E6")]
	[Address(RVA = "0x1847510", Offset = "0x1847510", VA = "0x1847510")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F7E7")]
	[Address(RVA = "0x18475B8", Offset = "0x18475B8", VA = "0x18475B8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F7E8")]
	[Address(RVA = "0x1847B98", Offset = "0x1847B98", VA = "0x1847B98")]
	private void InitBtns(List<PetActionData> anims)
	{
	}

	[Token(Token = "0x600F7E9")]
	[Address(RVA = "0x18487D4", Offset = "0x18487D4", VA = "0x18487D4")]
	private void InitBtn(UIButton btn, UISprite sprite, PetActionData d, int slotId)
	{
	}

	[Token(Token = "0x600F7EA")]
	[Address(RVA = "0x1848D7C", Offset = "0x1848D7C", VA = "0x1848D7C", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600F7EB")]
	[Address(RVA = "0x1848E04", Offset = "0x1848E04", VA = "0x1848E04")]
	private void ShowPanel(bool show = true)
	{
	}

	[Token(Token = "0x600F7EC")]
	[Address(RVA = "0x1848EBC", Offset = "0x1848EBC", VA = "0x1848EBC")]
	private void DoShowPanel()
	{
	}

	[Token(Token = "0x600F7ED")]
	[Address(RVA = "0x1847B34", Offset = "0x1847B34", VA = "0x1847B34")]
	private void HidePanel()
	{
	}

	[Token(Token = "0x600F7EE")]
	[Address(RVA = "0x184931C", Offset = "0x184931C", VA = "0x184931C")]
	private void OnClickAnim(PetActionData d, int slotId)
	{
	}

	[Token(Token = "0x600F7EF")]
	[Address(RVA = "0x1849954", Offset = "0x1849954", VA = "0x1849954")]
	private void OnClickCenterBtn()
	{
	}

	[Token(Token = "0x600F7F0")]
	[Address(RVA = "0x1849134", Offset = "0x1849134", VA = "0x1849134")]
	private void RepositionPanel()
	{
	}

	[Token(Token = "0x600F7F1")]
	[Address(RVA = "0x18486F4", Offset = "0x18486F4", VA = "0x18486F4")]
	private void UpdateCenterIcons()
	{
	}

	[Token(Token = "0x600F7F2")]
	[Address(RVA = "0x184974C", Offset = "0x184974C", VA = "0x184974C")]
	private void ShowKey(string key)
	{
	}

	[Token(Token = "0x600F7F3")]
	[Address(RVA = "0x1849B0C", Offset = "0x1849B0C", VA = "0x1849B0C")]
	private bool OnEscapeClick()
	{
		return default(bool);
	}

	[Token(Token = "0x600F7F4")]
	[Address(RVA = "0x1849C30", Offset = "0x1849C30", VA = "0x1849C30", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600F7F6")]
	[Address(RVA = "0x1849E64", Offset = "0x1849E64", VA = "0x1849E64")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F7F7")]
	[Address(RVA = "0x1849E6C", Offset = "0x1849E6C", VA = "0x1849E6C")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600F7F8")]
	[Address(RVA = "0x1849E74", Offset = "0x1849E74", VA = "0x1849E74")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
