using System.Collections.Generic;
using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20006F5")]
public class MovableShootingTargetData : MonoBehaviour
{
	[Token(Token = "0x4004B94")]
	[FieldOffset(Offset = "0xC")]
	public float MaxHP;

	[Token(Token = "0x4004B95")]
	[FieldOffset(Offset = "0x10")]
	public List<Vector3> MovePointList;

	[Token(Token = "0x4004B96")]
	[FieldOffset(Offset = "0x14")]
	public float DelayToNextPoint;

	[Token(Token = "0x4004B97")]
	[FieldOffset(Offset = "0x18")]
	public float DelayToRevive;

	[Token(Token = "0x4004B98")]
	[FieldOffset(Offset = "0x1C")]
	public float ReviveTime;

	[Token(Token = "0x4004B99")]
	[FieldOffset(Offset = "0x20")]
	public float MoveSpeed;

	[Token(Token = "0x4004B9A")]
	[FieldOffset(Offset = "0x24")]
	public string ModelResID;

	[Token(Token = "0x4004B9B")]
	[FieldOffset(Offset = "0x28")]
	public Transform ModelContainer;

	[Token(Token = "0x4004B9C")]
	[FieldOffset(Offset = "0x2C")]
	public Transform HitColliderContainer;

	[Token(Token = "0x4004B9D")]
	[FieldOffset(Offset = "0x30")]
	public GameObject WeaponGoodContainer;

	[Token(Token = "0x4004B9E")]
	[FieldOffset(Offset = "0x34")]
	public GameObject WeaponNormalContainer;

	[Token(Token = "0x4004B9F")]
	[FieldOffset(Offset = "0x38")]
	public GameObject WeaponBadContainer;

	[Token(Token = "0x4004BA0")]
	[FieldOffset(Offset = "0x3C")]
	public bool CouldSelectedInShootingGame;

	[Token(Token = "0x4004BA1")]
	[FieldOffset(Offset = "0x3D")]
	public bool NeedAimAssist;

	[Token(Token = "0x4004BA2")]
	[FieldOffset(Offset = "0x40")]
	public IFNLONPAKCK TargetType;

	[Token(Token = "0x4004BA3")]
	[FieldOffset(Offset = "0x44")]
	public uint Group;

	[Token(Token = "0x6002C81")]
	[Address(RVA = "0x228FFE8", Offset = "0x228FFE8", VA = "0x228FFE8")]
	public MovableShootingTargetData()
	{
	}
}
