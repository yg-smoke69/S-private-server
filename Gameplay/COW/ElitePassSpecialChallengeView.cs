using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003377")]
public class ElitePassSpecialChallengeView : MonoBehaviour
{
	[Token(Token = "0x401398C")]
	[FieldOffset(Offset = "0xC")]
	public GameObject SpecialUnlocked;

	[Token(Token = "0x401398D")]
	[FieldOffset(Offset = "0x10")]
	public GameObject SpecialToUnlock;

	[Token(Token = "0x401398E")]
	[FieldOffset(Offset = "0x14")]
	public GameObject NormalChallengeMark;

	[Token(Token = "0x401398F")]
	[FieldOffset(Offset = "0x18")]
	public GameObject NormalChallengeMarkLocked;

	[Token(Token = "0x4013990")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton m_ToUnlockButton;

	[Token(Token = "0x4013991")]
	[FieldOffset(Offset = "0x20")]
	private EPChallengeInfo m_CurChallengeInfo;

	[Token(Token = "0x6015E17")]
	[Address(RVA = "0x252FEA0", Offset = "0x252FEA0", VA = "0x252FEA0")]
	public ElitePassSpecialChallengeView()
	{
	}

	[Token(Token = "0x6015E18")]
	[Address(RVA = "0x252FEA8", Offset = "0x252FEA8", VA = "0x252FEA8")]
	private void Start()
	{
	}

	[Token(Token = "0x6015E19")]
	[Address(RVA = "0x252FFC8", Offset = "0x252FFC8", VA = "0x252FFC8")]
	public void SetData(EPChallengeInfo info)
	{
	}

	[Token(Token = "0x6015E1A")]
	[Address(RVA = "0x25300E4", Offset = "0x25300E4", VA = "0x25300E4")]
	public void SetDataForNormalMark(bool isUnlocked)
	{
	}

	[Token(Token = "0x6015E1B")]
	[Address(RVA = "0x25301DC", Offset = "0x25301DC", VA = "0x25301DC")]
	public void OnClickToUnlockButton()
	{
	}
}
