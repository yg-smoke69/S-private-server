using System.Collections.Generic;
using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200074E")]
public class LudoBoardNode : MonoBehaviour
{
	[Token(Token = "0x4004CEA")]
	[FieldOffset(Offset = "0xC")]
	public uint NodeID;

	[Token(Token = "0x4004CEB")]
	[FieldOffset(Offset = "0x10")]
	public int[] NodeTypes;

	[Token(Token = "0x4004CEC")]
	[FieldOffset(Offset = "0x14")]
	public uint ChessType;

	[Token(Token = "0x4004CED")]
	[FieldOffset(Offset = "0x18")]
	public uint ChessInitialNumber;

	[Token(Token = "0x4004CEE")]
	[FieldOffset(Offset = "0x1C")]
	public uint DistanceToFinish;

	[Token(Token = "0x4004CEF")]
	[FieldOffset(Offset = "0x20")]
	public uint FinishCount;

	[Token(Token = "0x4004CF0")]
	[FieldOffset(Offset = "0x24")]
	public LudoBoardNode NextNormalNode;

	[Token(Token = "0x4004CF1")]
	[FieldOffset(Offset = "0x28")]
	public LudoBoardNode NextSpecialNode;

	[Token(Token = "0x4004CF2")]
	[FieldOffset(Offset = "0x2C")]
	public List<IBPOEGELEPP> chessList;

	[Token(Token = "0x1700035E")]
	public uint NodeType
	{
		[Token(Token = "0x6002E03")]
		[Address(RVA = "0x1C639AC", Offset = "0x1C639AC", VA = "0x1C639AC")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x6002E02")]
	[Address(RVA = "0x1C63920", Offset = "0x1C63920", VA = "0x1C63920")]
	public LudoBoardNode()
	{
	}

	[Token(Token = "0x6002E04")]
	[Address(RVA = "0x1C63A2C", Offset = "0x1C63A2C", VA = "0x1C63A2C")]
	public bool IsPrepareNode()
	{
		return default(bool);
	}

	[Token(Token = "0x6002E05")]
	[Address(RVA = "0x1C63AB4", Offset = "0x1C63AB4", VA = "0x1C63AB4")]
	public bool IsFinishNode()
	{
		return default(bool);
	}

	[Token(Token = "0x6002E06")]
	[Address(RVA = "0x1C63B40", Offset = "0x1C63B40", VA = "0x1C63B40")]
	public bool IsStartNode()
	{
		return default(bool);
	}

	[Token(Token = "0x6002E07")]
	[Address(RVA = "0x1C63BCC", Offset = "0x1C63BCC", VA = "0x1C63BCC")]
	public bool IsProtectNode()
	{
		return default(bool);
	}

	[Token(Token = "0x6002E08")]
	[Address(RVA = "0x1C63C58", Offset = "0x1C63C58", VA = "0x1C63C58")]
	public void AddChess(IBPOEGELEPP chess)
	{
	}

	[Token(Token = "0x6002E09")]
	[Address(RVA = "0x1C63CD8", Offset = "0x1C63CD8", VA = "0x1C63CD8")]
	public void DeleteChess(IBPOEGELEPP chess)
	{
	}

	[Token(Token = "0x6002E0A")]
	[Address(RVA = "0x1C63D60", Offset = "0x1C63D60", VA = "0x1C63D60")]
	public void AdjustChess()
	{
	}
}
