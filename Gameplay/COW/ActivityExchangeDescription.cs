using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2001E82")]
public class ActivityExchangeDescription : MonoBehaviour
{
	[Token(Token = "0x2001E83")]
	private enum OperateStatus
	{
		[Token(Token = "0x400BFF1")]
		None,
		[Token(Token = "0x400BFF2")]
		Exchange,
		[Token(Token = "0x400BFF3")]
		ExchangeNo,
		[Token(Token = "0x400BFF4")]
		ExchangeFinished
	}

	[Token(Token = "0x400BFE1")]
	[FieldOffset(Offset = "0xC")]
	public ActivityAwardItem ConsumeItemTemplate;

	[Token(Token = "0x400BFE2")]
	[FieldOffset(Offset = "0x10")]
	public ActivityAwardItem ExchangeItem;

	[Token(Token = "0x400BFE3")]
	[FieldOffset(Offset = "0x14")]
	public UIButton OperateButton;

	[Token(Token = "0x400BFE4")]
	[FieldOffset(Offset = "0x18")]
	public UISprite OperateGray;

	[Token(Token = "0x400BFE5")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite OperateYellow;

	[Token(Token = "0x400BFE6")]
	[FieldOffset(Offset = "0x20")]
	public UISprite SplitLineSpr;

	[Token(Token = "0x400BFE7")]
	[FieldOffset(Offset = "0x24")]
	public UILabel OperateTitle;

	[Token(Token = "0x400BFE8")]
	[FieldOffset(Offset = "0x28")]
	public UILabel Progress;

	[Token(Token = "0x400BFE9")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject Equal;

	[Token(Token = "0x400BFEA")]
	[FieldOffset(Offset = "0x30")]
	public float Space;

	[Token(Token = "0x400BFEB")]
	[FieldOffset(Offset = "0x34")]
	private ClientActivityDesc m_Desc;

	[Token(Token = "0x400BFEC")]
	[FieldOffset(Offset = "0x38")]
	private OperateStatus m_OperateStatus;

	[Token(Token = "0x400BFED")]
	[FieldOffset(Offset = "0x3C")]
	private UIModelActivity m_ModelActivity;

	[Token(Token = "0x400BFEE")]
	[FieldOffset(Offset = "0x40")]
	private List<ActivityAwardItem> m_ConsumeItemUIs;

	[Token(Token = "0x400BFEF")]
	[FieldOffset(Offset = "0x44")]
	private Color32 m_GrayColor;

	[Token(Token = "0x60092CA")]
	[Address(RVA = "0x14BE7C4", Offset = "0x14BE7C4", VA = "0x14BE7C4")]
	public ActivityExchangeDescription()
	{
	}

	[Token(Token = "0x60092CB")]
	[Address(RVA = "0x14BE824", Offset = "0x14BE824", VA = "0x14BE824")]
	private void Start()
	{
	}

	[Token(Token = "0x60092CC")]
	[Address(RVA = "0x14BE944", Offset = "0x14BE944", VA = "0x14BE944")]
	private void Update()
	{
	}

	[Token(Token = "0x60092CD")]
	[Address(RVA = "0x14BE998", Offset = "0x14BE998", VA = "0x14BE998")]
	public void SetData(ClientActivityDesc desc)
	{
	}

	[Token(Token = "0x60092CE")]
	[Address(RVA = "0x14C0134", Offset = "0x14C0134", VA = "0x14C0134")]
	public void DisableSplitLineUI()
	{
	}

	[Token(Token = "0x60092CF")]
	[Address(RVA = "0x14BEAD4", Offset = "0x14BEAD4", VA = "0x14BEAD4")]
	private void SetOperateButtonUI()
	{
	}

	[Token(Token = "0x60092D0")]
	[Address(RVA = "0x14BF218", Offset = "0x14BF218", VA = "0x14BF218")]
	private void CreateConsumeItems()
	{
	}

	[Token(Token = "0x60092D1")]
	[Address(RVA = "0x14BF868", Offset = "0x14BF868", VA = "0x14BF868")]
	private void CreateAwardItems(List<AwardDesc> awards)
	{
	}

	[Token(Token = "0x60092D2")]
	[Address(RVA = "0x14C0254", Offset = "0x14C0254", VA = "0x14C0254")]
	private void OnOperate()
	{
	}

	[Token(Token = "0x60092D3")]
	[Address(RVA = "0x14C0900", Offset = "0x14C0900", VA = "0x14C0900")]
	public void Reload()
	{
	}

	[Token(Token = "0x60092D4")]
	[Address(RVA = "0x14C0A9C", Offset = "0x14C0A9C", VA = "0x14C0A9C")]
	private void _003COnOperate_003Em__0()
	{
	}
}
