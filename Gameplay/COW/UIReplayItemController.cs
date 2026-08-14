using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002ACD")]
public class UIReplayItemController : UIEasyListItemController
{
	[Token(Token = "0x40106EE")]
	[FieldOffset(Offset = "0x38")]
	private UIReplayListItemView m_View;

	[Token(Token = "0x40106EF")]
	[FieldOffset(Offset = "0x3C")]
	private MobileReplayInfo m_RecordData;

	[Token(Token = "0x40106F0")]
	[FieldOffset(Offset = "0x40")]
	private UIModelReplay m_Model;

	[Token(Token = "0x40106F1")]
	private const string COLOR_YELLOW = "ffba00";

	[Token(Token = "0x40106F2")]
	private const string COLOR_WHITE = "ffffff";

	[Token(Token = "0x40106F3")]
	private const string COLOR_GRAY = "bababa";

	[Token(Token = "0x40106F4")]
	private const int YELLOW_RANK = 3;

	[Token(Token = "0x40106F5")]
	private const string POSITIVE_DELTA_COLOR = "4cd5ad";

	[Token(Token = "0x40106F6")]
	private const string NEGATIVE_DELTA_COLOR = "ff0032";

	[Token(Token = "0x601189C")]
	[Address(RVA = "0x1E51194", Offset = "0x1E51194", VA = "0x1E51194")]
	public UIReplayItemController()
	{
	}

	[Token(Token = "0x601189D")]
	[Address(RVA = "0x1E5119C", Offset = "0x1E5119C", VA = "0x1E5119C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x601189E")]
	[Address(RVA = "0x1E514C4", Offset = "0x1E514C4", VA = "0x1E514C4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601189F")]
	[Address(RVA = "0x1E51568", Offset = "0x1E51568", VA = "0x1E51568")]
	private void UpdateResultColumn()
	{
	}

	[Token(Token = "0x60118A0")]
	[Address(RVA = "0x1E51AB0", Offset = "0x1E51AB0", VA = "0x1E51AB0")]
	private void UpdateModeColumn()
	{
	}

	[Token(Token = "0x60118A1")]
	[Address(RVA = "0x1E52190", Offset = "0x1E52190", VA = "0x1E52190")]
	private void UpdateKillsColumn()
	{
	}

	[Token(Token = "0x60118A2")]
	[Address(RVA = "0x1E52244", Offset = "0x1E52244", VA = "0x1E52244")]
	private void UpdateTimeColumn()
	{
	}

	[Token(Token = "0x60118A3")]
	[Address(RVA = "0x1E52670", Offset = "0x1E52670", VA = "0x1E52670", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x60118A4")]
	[Address(RVA = "0x1E52A44", Offset = "0x1E52A44", VA = "0x1E52A44")]
	private void ShowHighlightGuide()
	{
	}

	[Token(Token = "0x60118A5")]
	[Address(RVA = "0x1E531C0", Offset = "0x1E531C0", VA = "0x1E531C0")]
	private void OnPlayClick()
	{
	}

	[Token(Token = "0x60118A6")]
	[Address(RVA = "0x1E533C4", Offset = "0x1E533C4", VA = "0x1E533C4")]
	private void OnDelClick()
	{
	}

	[Token(Token = "0x60118A7")]
	[Address(RVA = "0x1E536FC", Offset = "0x1E536FC", VA = "0x1E536FC")]
	private void OnSaveClick()
	{
	}

	[Token(Token = "0x60118A8")]
	[Address(RVA = "0x1E53AA8", Offset = "0x1E53AA8", VA = "0x1E53AA8", Slot = "32")]
	public override void OnItemBtnClick()
	{
	}

	[Token(Token = "0x60118A9")]
	[Address(RVA = "0x1E53C64", Offset = "0x1E53C64", VA = "0x1E53C64")]
	private void _003COnDelClick_003Em__0()
	{
	}

	[Token(Token = "0x60118AA")]
	[Address(RVA = "0x1E53FC8", Offset = "0x1E53FC8", VA = "0x1E53FC8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60118AB")]
	[Address(RVA = "0x1E53FD0", Offset = "0x1E53FD0", VA = "0x1E53FD0")]
	public void _003C_003EiFixBaseProxy_OnItemBtnClick()
	{
	}
}
