using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002530")]
internal class UIClanBaseItemController : UIEasyListItemController
{
	[Token(Token = "0x2002531")]
	private sealed class _003COnPopMenuClick_003Ec__AnonStorey0
	{
		[Token(Token = "0x400E690")]
		[FieldOffset(Offset = "0x8")]
		internal EClanOperation op;

		[Token(Token = "0x400E691")]
		[FieldOffset(Offset = "0xC")]
		internal ClanMember member_data;

		[Token(Token = "0x600D860")]
		[Address(RVA = "0x2F25D00", Offset = "0x2F25D00", VA = "0x2F25D00")]
		public _003COnPopMenuClick_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600D861")]
		[Address(RVA = "0x2F270E8", Offset = "0x2F270E8", VA = "0x2F270E8")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x400E67A")]
	[FieldOffset(Offset = "0x38")]
	protected UIButton BtnShowDeatil;

	[Token(Token = "0x400E67B")]
	[FieldOffset(Offset = "0x3C")]
	protected UISprite SelectLine;

	[Token(Token = "0x400E67C")]
	[FieldOffset(Offset = "0x40")]
	protected UIWidget ClanItemInfoContainer;

	[Token(Token = "0x400E67D")]
	[FieldOffset(Offset = "0x44")]
	protected UISprite ClanPosition;

	[Token(Token = "0x400E67E")]
	[FieldOffset(Offset = "0x48")]
	protected UIButton BtnClanPosition;

	[Token(Token = "0x400E67F")]
	[FieldOffset(Offset = "0x4C")]
	protected UILabel HonorPointLabel;

	[Token(Token = "0x400E680")]
	[FieldOffset(Offset = "0x50")]
	protected UILabel AccountState;

	[Token(Token = "0x400E681")]
	[FieldOffset(Offset = "0x54")]
	protected UILabel AccountState_Online;

	[Token(Token = "0x400E682")]
	[FieldOffset(Offset = "0x58")]
	protected UILabel AccountState_Offline;

	[Token(Token = "0x400E683")]
	[FieldOffset(Offset = "0x5C")]
	protected UILabel AccountState_InGame;

	[Token(Token = "0x400E684")]
	[FieldOffset(Offset = "0x60")]
	protected Transform AccountInfoContainer;

	[Token(Token = "0x400E685")]
	[FieldOffset(Offset = "0x64")]
	protected GameObject ApplyBtnGroup;

	[Token(Token = "0x400E686")]
	[FieldOffset(Offset = "0x68")]
	protected UIButton BtnComfirm;

	[Token(Token = "0x400E687")]
	[FieldOffset(Offset = "0x6C")]
	protected UIButton BtnRefuse;

	[Token(Token = "0x400E688")]
	[FieldOffset(Offset = "0x70")]
	protected object m_Data;

	[Token(Token = "0x400E689")]
	[FieldOffset(Offset = "0x74")]
	protected UIBaseProfileInfoController m_BaseProfile;

	[Token(Token = "0x400E68A")]
	[FieldOffset(Offset = "0x78")]
	protected string m_ClanPosition;

	[Token(Token = "0x400E68B")]
	[FieldOffset(Offset = "0x7C")]
	protected uint COLOR_ONLINE;

	[Token(Token = "0x400E68C")]
	[FieldOffset(Offset = "0x80")]
	protected uint COLOR_OFFLINE;

	[Token(Token = "0x400E68D")]
	[FieldOffset(Offset = "0x84")]
	protected uint COLOR_INGAME;

	[Token(Token = "0x400E68E")]
	[FieldOffset(Offset = "0x88")]
	protected GameObject BGEven;

	[Token(Token = "0x400E68F")]
	[FieldOffset(Offset = "0x8C")]
	protected GameObject BGOdd;

	[Token(Token = "0x600D84F")]
	[Address(RVA = "0x2F1F374", Offset = "0x2F1F374", VA = "0x2F1F374")]
	public UIClanBaseItemController()
	{
	}

	[Token(Token = "0x600D850")]
	[Address(RVA = "0x2F1F66C", Offset = "0x2F1F66C", VA = "0x2F1F66C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D851")]
	[Address(RVA = "0x2F24230", Offset = "0x2F24230", VA = "0x2F24230")]
	private void OnBtnShowDetailClick()
	{
	}

	[Token(Token = "0x600D852")]
	[Address(RVA = "0x2F250C4", Offset = "0x2F250C4", VA = "0x2F250C4", Slot = "32")]
	public override void OnItemBtnClick()
	{
	}

	[Token(Token = "0x600D853")]
	[Address(RVA = "0x2F25128", Offset = "0x2F25128", VA = "0x2F25128")]
	private void OnPopMenuClick(object obj)
	{
	}

	[Token(Token = "0x600D854")]
	[Address(RVA = "0x2F25D08", Offset = "0x2F25D08", VA = "0x2F25D08", Slot = "34")]
	public override void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600D855")]
	[Address(RVA = "0x2F25DB0", Offset = "0x2F25DB0", VA = "0x2F25DB0", Slot = "35")]
	public override void OnItemBtnUnSelect()
	{
	}

	[Token(Token = "0x600D856")]
	[Address(RVA = "0x2F25E58", Offset = "0x2F25E58", VA = "0x2F25E58")]
	public void SetItemSelect(bool isSelected)
	{
	}

	[Token(Token = "0x600D857")]
	[Address(RVA = "0x2F25EFC", Offset = "0x2F25EFC", VA = "0x2F25EFC")]
	private void OnConfirmClick()
	{
	}

	[Token(Token = "0x600D858")]
	[Address(RVA = "0x2F26084", Offset = "0x2F26084", VA = "0x2F26084")]
	private void OnRefuseClick()
	{
	}

	[Token(Token = "0x600D859")]
	[Address(RVA = "0x2F2620C", Offset = "0x2F2620C", VA = "0x2F2620C")]
	private void OnClanPositionClick()
	{
	}

	[Token(Token = "0x600D85A")]
	[Address(RVA = "0x2F263B0", Offset = "0x2F263B0", VA = "0x2F263B0", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600D85B")]
	[Address(RVA = "0x2F27050", Offset = "0x2F27050", VA = "0x2F27050")]
	private float GetAlpha(EPresence.AccountPresence status)
	{
		return default(float);
	}

	[Token(Token = "0x600D85C")]
	[Address(RVA = "0x2F270C8", Offset = "0x2F270C8", VA = "0x2F270C8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D85D")]
	[Address(RVA = "0x2F270D0", Offset = "0x2F270D0", VA = "0x2F270D0")]
	public void _003C_003EiFixBaseProxy_OnItemBtnClick()
	{
	}

	[Token(Token = "0x600D85E")]
	[Address(RVA = "0x2F270D8", Offset = "0x2F270D8", VA = "0x2F270D8")]
	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600D85F")]
	[Address(RVA = "0x2F270E0", Offset = "0x2F270E0", VA = "0x2F270E0")]
	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
