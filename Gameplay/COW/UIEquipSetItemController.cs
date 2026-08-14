using System;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002607")]
public class UIEquipSetItemController : UIBaseController
{
	[Token(Token = "0x2002608")]
	private sealed class _003CPlayForbidEffect_003Ec__AnonStorey0
	{
		[Token(Token = "0x400EADD")]
		[FieldOffset(Offset = "0x8")]
		internal string name;

		[Token(Token = "0x400EADE")]
		[FieldOffset(Offset = "0xC")]
		internal UIEquipSetItemController _0024this;

		[Token(Token = "0x600E0DA")]
		[Address(RVA = "0x19D7928", Offset = "0x19D7928", VA = "0x19D7928")]
		public _003CPlayForbidEffect_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600E0DB")]
		[Address(RVA = "0x19D79F0", Offset = "0x19D79F0", VA = "0x19D79F0")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x400EAD8")]
	[FieldOffset(Offset = "0x28")]
	private UIEquipSetItemView m_View;

	[Token(Token = "0x400EAD9")]
	[FieldOffset(Offset = "0x2C")]
	public int m_Index;

	[Token(Token = "0x400EADA")]
	[FieldOffset(Offset = "0x30")]
	public Action<int> OnSelect;

	[Token(Token = "0x400EADB")]
	[FieldOffset(Offset = "0x34")]
	public LinkEquipSetData m_equipSetData;

	[Token(Token = "0x400EADC")]
	[FieldOffset(Offset = "0x38")]
	public bool m_IsForbid;

	[Token(Token = "0x600E0CC")]
	[Address(RVA = "0x19D688C", Offset = "0x19D688C", VA = "0x19D688C")]
	public UIEquipSetItemController()
	{
	}

	[Token(Token = "0x600E0CD")]
	[Address(RVA = "0x19D6910", Offset = "0x19D6910", VA = "0x19D6910")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E0CE")]
	[Address(RVA = "0x19D69B4", Offset = "0x19D69B4", VA = "0x19D69B4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E0CF")]
	[Address(RVA = "0x19D6BB4", Offset = "0x19D6BB4", VA = "0x19D6BB4")]
	public void SetUIData(int index, LinkEquipSetData data)
	{
	}

	[Token(Token = "0x600E0D0")]
	[Address(RVA = "0x19D6E74", Offset = "0x19D6E74", VA = "0x19D6E74")]
	private void SetEquips(EquipIdCountDataList data, GameObject widget, UILabel nameLabel, UISprite icon, bool bigIcon = false)
	{
	}

	[Token(Token = "0x600E0D1")]
	[Address(RVA = "0x19D7128", Offset = "0x19D7128", VA = "0x19D7128")]
	private LGCOKIBHIJL SetEquipWidget(EquipIdCountDataList data, GameObject widget)
	{
		return null;
	}

	[Token(Token = "0x600E0D2")]
	[Address(RVA = "0x19D7318", Offset = "0x19D7318", VA = "0x19D7318")]
	private void SetEquips(LGCOKIBHIJL itemData, UILabel nameLabel, UISprite icon, bool bigIcon)
	{
	}

	[Token(Token = "0x600E0D3")]
	[Address(RVA = "0x19D6F2C", Offset = "0x19D6F2C", VA = "0x19D6F2C")]
	private void SetArmor(EquipIdCountDataList data, GameObject widget, UISprite icon)
	{
	}

	[Token(Token = "0x600E0D4")]
	[Address(RVA = "0x19D6B1C", Offset = "0x19D6B1C", VA = "0x19D6B1C")]
	public void Highlight(bool highlight)
	{
	}

	[Token(Token = "0x600E0D5")]
	[Address(RVA = "0x19D74EC", Offset = "0x19D74EC", VA = "0x19D74EC")]
	public void SetForbidChoose(bool choosed, string name = "")
	{
	}

	[Token(Token = "0x600E0D6")]
	[Address(RVA = "0x19D7890", Offset = "0x19D7890", VA = "0x19D7890")]
	public void SetEscortModeInfo(string info)
	{
	}

	[Token(Token = "0x600E0D7")]
	[Address(RVA = "0x19D7674", Offset = "0x19D7674", VA = "0x19D7674")]
	private void PlayForbidEffect(GameObject go, string name)
	{
	}

	[Token(Token = "0x600E0D8")]
	[Address(RVA = "0x19D7930", Offset = "0x19D7930", VA = "0x19D7930")]
	private void OnClick()
	{
	}

	[Token(Token = "0x600E0D9")]
	[Address(RVA = "0x19D79E8", Offset = "0x19D79E8", VA = "0x19D79E8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
