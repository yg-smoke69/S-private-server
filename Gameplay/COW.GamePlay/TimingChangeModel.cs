using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x200400E")]
internal class TimingChangeModel : MonoBehaviour, _Attribute
{
	[Token(Token = "0x401AF07")]
	[FieldOffset(Offset = "0xC")]
	public int m_ChangeModelTime;

	[Token(Token = "0x401AF08")]
	[FieldOffset(Offset = "0x10")]
	public string m_ModleID;

	[Token(Token = "0x401AF09")]
	[FieldOffset(Offset = "0x14")]
	public string m_ChangeEffectID;

	[Token(Token = "0x401AF0A")]
	[FieldOffset(Offset = "0x18")]
	public string m_ChangeSoundID;

	[Token(Token = "0x401AF0B")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject m_Modle;

	[Token(Token = "0x401AF0C")]
	[FieldOffset(Offset = "0x20")]
	private UIModelMatch FHELAHPLGLE;

	[Token(Token = "0x601A156")]
	[Address(RVA = "0x1D836B8", Offset = "0x1D836B8", VA = "0x1D836B8")]
	public TimingChangeModel()
	{
	}

	[Token(Token = "0x601A157")]
	[Address(RVA = "0x1D836C0", Offset = "0x1D836C0", VA = "0x1D836C0")]
	private void Start()
	{
	}

	[Token(Token = "0x601A158")]
	[Address(RVA = "0x1D837D8", Offset = "0x1D837D8", VA = "0x1D837D8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x601A159")]
	[Address(RVA = "0x1D83848", Offset = "0x1D83848", VA = "0x1D83848", Slot = "4")]
	public void OnDataChanged(UIBaseModel GDOGIGDHJJO, uint COHGGHHBNGG, object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x601A15A")]
	[Address(RVA = "0x1D841B0", Offset = "0x1D841B0", VA = "0x1D841B0", Slot = "5")]
	public uint GetInterestedPropID(UIBaseModel GDOGIGDHJJO)
	{
		return default(uint);
	}
}
