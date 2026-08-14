using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000BB5")]
public class BE_BlockSpot : MonoBehaviour, _Attribute
{
	[Token(Token = "0x4006251")]
	[FieldOffset(Offset = "0xC")]
	private UIWidget ICNJGBNAGJJ;

	[Token(Token = "0x4006252")]
	[FieldOffset(Offset = "0x10")]
	private Transform FFOKIJCMHMM;

	[Token(Token = "0x4006253")]
	[FieldOffset(Offset = "0x14")]
	public BE_Block Block;

	[Token(Token = "0x4006254")]
	[FieldOffset(Offset = "0x18")]
	public UITable Table;

	[Token(Token = "0x4006255")]
	[FieldOffset(Offset = "0x1C")]
	public CABKKILKHNJ m_Type;

	[Token(Token = "0x4006256")]
	[FieldOffset(Offset = "0x20")]
	public Transform m_HighLightPos;

	[Token(Token = "0x1700072F")]
	public Transform AAPOHEDPNDG
	{
		[Token(Token = "0x60058CE")]
		[Address(RVA = "0x2D2566C", Offset = "0x2D2566C", VA = "0x2D2566C", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000730")]
	public Vector2 KNNEHMMMMLI
	{
		[Token(Token = "0x60058CF")]
		[Address(RVA = "0x2D256C4", Offset = "0x2D256C4", VA = "0x2D256C4", Slot = "5")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector2);
		}
	}

	[Token(Token = "0x17000731")]
	public CABKKILKHNJ HMEBLIODHEO
	{
		[Token(Token = "0x60058D0")]
		[Address(RVA = "0x2D257DC", Offset = "0x2D257DC", VA = "0x2D257DC", Slot = "6")]
		get
		{
			return default(CABKKILKHNJ);
		}
	}

	[Token(Token = "0x17000732")]
	public Transform PPCIDFMHAAN
	{
		[Token(Token = "0x60058D1")]
		[Address(RVA = "0x2D25834", Offset = "0x2D25834", VA = "0x2D25834", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60058CD")]
	[Address(RVA = "0x2D25664", Offset = "0x2D25664", VA = "0x2D25664")]
	public BE_BlockSpot()
	{
	}

	[Token(Token = "0x60058D2")]
	[Address(RVA = "0x2D2588C", Offset = "0x2D2588C", VA = "0x2D2588C")]
	private void Awake()
	{
	}
}
