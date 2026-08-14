using System.Collections.Generic;
using System.Text.RegularExpressions;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002DB4")]
public class BlockLabelManager : SingletonModule<BlockLabelManager>
{
	[Token(Token = "0x2002DB5")]
	private enum ELabelType
	{
		[Token(Token = "0x40118A8")]
		Url,
		[Token(Token = "0x40118A9")]
		Email,
		[Token(Token = "0x40118AA")]
		PhoneNum
	}

	[Token(Token = "0x401189E")]
	[FieldOffset(Offset = "0xC")]
	private UIModelLogin m_ModelLogin;

	[Token(Token = "0x401189F")]
	[FieldOffset(Offset = "0x10")]
	private string m_Text;

	[Token(Token = "0x40118A0")]
	[FieldOffset(Offset = "0x14")]
	private List<string> m_BlockPattern;

	[Token(Token = "0x40118A1")]
	[FieldOffset(Offset = "0x18")]
	private Regex m_Regex;

	[Token(Token = "0x40118A2")]
	private const uint m_LabelTypeNum = 3u;

	[Token(Token = "0x40118A3")]
	private const uint m_PhoneNumCount = 8u;

	[Token(Token = "0x40118A4")]
	private const string m_TipKey = "BR_ACCOUNT_DIRTY_NAME";

	[Token(Token = "0x40118A5")]
	[FieldOffset(Offset = "0x1C")]
	private HashSet<int> m_PhoneNumSet;

	[Token(Token = "0x40118A6")]
	[FieldOffset(Offset = "0x0")]
	private static MatchEvaluator _003C_003Ef__am_0024cache0;

	[Token(Token = "0x6013223")]
	[Address(RVA = "0x180BA08", Offset = "0x180BA08", VA = "0x180BA08")]
	public BlockLabelManager()
	{
	}

	[Token(Token = "0x6013224")]
	[Address(RVA = "0x180BB14", Offset = "0x180BB14", VA = "0x180BB14", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6013225")]
	[Address(RVA = "0x180BD18", Offset = "0x180BD18", VA = "0x180BD18", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x6013226")]
	[Address(RVA = "0x180BDEC", Offset = "0x180BDEC", VA = "0x180BDEC")]
	public bool ContainBlockLabel(string text, bool showTip = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6013227")]
	[Address(RVA = "0x180C31C", Offset = "0x180C31C", VA = "0x180C31C")]
	public string GetRapaceText(string text)
	{
		return null;
	}

	[Token(Token = "0x6013228")]
	[Address(RVA = "0x180C0C4", Offset = "0x180C0C4", VA = "0x180C0C4")]
	private bool ContainBlockLabel(int labelType)
	{
		return default(bool);
	}

	[Token(Token = "0x6013229")]
	[Address(RVA = "0x180C6AC", Offset = "0x180C6AC", VA = "0x180C6AC")]
	private bool ContainBlockPhoneNum()
	{
		return default(bool);
	}

	[Token(Token = "0x601322A")]
	[Address(RVA = "0x180C44C", Offset = "0x180C44C", VA = "0x180C44C")]
	private void ReplaceBlockLabel(int labelType)
	{
	}

	[Token(Token = "0x601322B")]
	[Address(RVA = "0x180CC40", Offset = "0x180CC40", VA = "0x180CC40")]
	private string _003CReplaceBlockLabel_003Em__0(Match match)
	{
		return null;
	}

	[Token(Token = "0x601322C")]
	[Address(RVA = "0x180CE38", Offset = "0x180CE38", VA = "0x180CE38")]
	private static string _003CReplaceBlockLabel_003Em__1(Match match)
	{
		return null;
	}
}
