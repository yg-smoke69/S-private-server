using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2001F94")]
public class UIBigEventTopBtnBaseController : UIBaseController
{
	[Token(Token = "0x2001F95")]
	private sealed class _003CInitTokenBtn_003Ec__AnonStorey0
	{
		[Token(Token = "0x400C634")]
		[FieldOffset(Offset = "0x8")]
		internal uint tokenId;

		[Token(Token = "0x400C635")]
		[FieldOffset(Offset = "0xC")]
		internal Transform tipPos;

		[Token(Token = "0x400C636")]
		[FieldOffset(Offset = "0x10")]
		internal UIBigEventTopBtnBaseController _0024this;

		[Token(Token = "0x6009D3D")]
		[Address(RVA = "0x3019D74", Offset = "0x3019D74", VA = "0x3019D74")]
		public _003CInitTokenBtn_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6009D3E")]
		[Address(RVA = "0x301A178", Offset = "0x301A178", VA = "0x301A178")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x400C631")]
	[FieldOffset(Offset = "0x28")]
	private UIBigEventTopBtnBaseView m_View;

	[Token(Token = "0x400C632")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelBigEvent.EBigEventEntranceID m_EntranceID;

	[Token(Token = "0x400C633")]
	[FieldOffset(Offset = "0x30")]
	protected ELimitedEvent.EventID m_EventID;

	[Token(Token = "0x17000F9D")]
	public UIBigEventTopBtnBaseView BaseView
	{
		[Token(Token = "0x6009D35")]
		[Address(RVA = "0x301939C", Offset = "0x301939C", VA = "0x301939C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6009D36")]
		[Address(RVA = "0x3019498", Offset = "0x3019498", VA = "0x3019498")]
		set
		{
		}
	}

	[Token(Token = "0x6009D33")]
	[Address(RVA = "0x3019238", Offset = "0x3019238", VA = "0x3019238")]
	public UIBigEventTopBtnBaseController()
	{
	}

	[Token(Token = "0x6009D34")]
	[Address(RVA = "0x30192C4", Offset = "0x30192C4", VA = "0x30192C4", Slot = "31")]
	public virtual string GetTokenClickSoundId()
	{
		return null;
	}

	[Token(Token = "0x6009D37")]
	[Address(RVA = "0x30194F8", Offset = "0x30194F8", VA = "0x30194F8")]
	public void SetEntranceId(UIModelBigEvent.EBigEventEntranceID entranceId = UIModelBigEvent.EBigEventEntranceID.Main)
	{
	}

	[Token(Token = "0x6009D38")]
	[Address(RVA = "0x3019558", Offset = "0x3019558", VA = "0x3019558", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009D39")]
	[Address(RVA = "0x3019614", Offset = "0x3019614", VA = "0x3019614")]
	public void SetViewData(uint sugarTokenId, uint storeTokenId, Callback onBtnClose)
	{
	}

	[Token(Token = "0x6009D3A")]
	[Address(RVA = "0x301994C", Offset = "0x301994C", VA = "0x301994C")]
	private void InitTokenBtn(uint tokenId, UISprite tokenSprite, UIButton btnToken, UILabel tokenCount, Transform tipPos)
	{
	}

	[Token(Token = "0x6009D3B")]
	[Address(RVA = "0x3019D7C", Offset = "0x3019D7C", VA = "0x3019D7C")]
	private void OnTokenTipClick(uint tokinId, Transform trans)
	{
	}

	[Token(Token = "0x6009D3C")]
	[Address(RVA = "0x301A170", Offset = "0x301A170", VA = "0x301A170")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
