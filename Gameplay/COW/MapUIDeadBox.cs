using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002D2D")]
public class MapUIDeadBox : MonoBehaviour
{
	[Token(Token = "0x401140C")]
	[FieldOffset(Offset = "0xC")]
	private UISprite m_icon;

	[Token(Token = "0x401140D")]
	[FieldOffset(Offset = "0x10")]
	private ConditionAction m_delayCall;

	[Token(Token = "0x6012E3E")]
	[Address(RVA = "0x153C7FC", Offset = "0x153C7FC", VA = "0x153C7FC")]
	public MapUIDeadBox()
	{
	}

	[Token(Token = "0x6012E3F")]
	[Address(RVA = "0x153C804", Offset = "0x153C804", VA = "0x153C804")]
	public void OnDead(bool isLocal, Vector3 pos)
	{
	}

	[Token(Token = "0x6012E40")]
	[Address(RVA = "0x153CBA0", Offset = "0x153CBA0", VA = "0x153CBA0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6012E41")]
	[Address(RVA = "0x153CC14", Offset = "0x153CC14", VA = "0x153CC14")]
	private bool _003COnDead_003Em__0()
	{
		return default(bool);
	}
}
