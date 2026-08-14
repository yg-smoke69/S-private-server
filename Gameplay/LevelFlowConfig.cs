using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using message;

[Token(Token = "0x200045D")]
public class LevelFlowConfig : MonoBehaviour
{
	[Token(Token = "0x4003CAA")]
	[FieldOffset(Offset = "0xC")]
	public int LevelID;

	[Token(Token = "0x4003CAB")]
	[FieldOffset(Offset = "0x10")]
	public GLGIEANPOKB LevelFinishType;

	[Token(Token = "0x4003CAC")]
	[FieldOffset(Offset = "0x14")]
	public float LevelTimeMinute;

	[Token(Token = "0x4003CAD")]
	[FieldOffset(Offset = "0x18")]
	public float LevelScore;

	[Token(Token = "0x4003CAE")]
	[FieldOffset(Offset = "0x1C")]
	public List<RankScore> RankScoreConifg;

	[Token(Token = "0x4003CAF")]
	[FieldOffset(Offset = "0x20")]
	public List<Transform> LevelPlayerStartPoints;

	[Token(Token = "0x4003CB0")]
	[FieldOffset(Offset = "0x24")]
	public List<Collider> FinishTriggers;

	[Token(Token = "0x4003CB1")]
	[FieldOffset(Offset = "0x28")]
	public List<Collider> KillZones;

	[Token(Token = "0x4003CB2")]
	[FieldOffset(Offset = "0x2C")]
	public List<Collider> CheckPointTriggers;

	[Token(Token = "0x60015E4")]
	[Address(RVA = "0x311364C", Offset = "0x311364C", VA = "0x311364C")]
	public LevelFlowConfig()
	{
	}
}
