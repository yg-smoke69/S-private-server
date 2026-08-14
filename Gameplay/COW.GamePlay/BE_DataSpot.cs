using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000BB7")]
public class BE_DataSpot : MonoBehaviour, _Attribute
{
	[Token(Token = "0x400626E")]
	[FieldOffset(Offset = "0xC")]
	private UIWidget ICNJGBNAGJJ;

	[Token(Token = "0x400626F")]
	[FieldOffset(Offset = "0x10")]
	private Transform FFOKIJCMHMM;

	[Token(Token = "0x4006270")]
	[FieldOffset(Offset = "0x14")]
	public BE_DataBlock BelongDataBlock;

	[Token(Token = "0x4006271")]
	[FieldOffset(Offset = "0x18")]
	public CABKKILKHNJ m_Type;

	[Token(Token = "0x4006272")]
	[FieldOffset(Offset = "0x1C")]
	public Transform m_HighLightPos;

	[Token(Token = "0x1700073B")]
	public Transform AAPOHEDPNDG
	{
		[Token(Token = "0x60058EC")]
		[Address(RVA = "0x2D27F04", Offset = "0x2D27F04", VA = "0x2D27F04", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700073C")]
	public Vector2 KNNEHMMMMLI
	{
		[Token(Token = "0x60058ED")]
		[Address(RVA = "0x2D27F5C", Offset = "0x2D27F5C", VA = "0x2D27F5C", Slot = "5")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector2);
		}
	}

	[Token(Token = "0x1700073D")]
	public CABKKILKHNJ HMEBLIODHEO
	{
		[Token(Token = "0x60058EE")]
		[Address(RVA = "0x2D28074", Offset = "0x2D28074", VA = "0x2D28074", Slot = "6")]
		get
		{
			return default(CABKKILKHNJ);
		}
	}

	[Token(Token = "0x1700073E")]
	public Transform PPCIDFMHAAN
	{
		[Token(Token = "0x60058EF")]
		[Address(RVA = "0x2D280CC", Offset = "0x2D280CC", VA = "0x2D280CC", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60058EB")]
	[Address(RVA = "0x2D27EFC", Offset = "0x2D27EFC", VA = "0x2D27EFC")]
	public BE_DataSpot()
	{
	}

	[Token(Token = "0x60058F0")]
	[Address(RVA = "0x2D28124", Offset = "0x2D28124", VA = "0x2D28124")]
	private void Awake()
	{
	}
}
