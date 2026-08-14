using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200071B")]
public class SpawnObjectCrossHairTrigger : MonoBehaviour
{
	[Token(Token = "0x4004C20")]
	private const uint FLAGID_VEHICLE = 1u;

	[Token(Token = "0x4004C21")]
	private const uint FLAGID_HUMAN = 2u;

	[Token(Token = "0x4004C22")]
	[FieldOffset(Offset = "0xC")]
	public GameObject Model;

	[Token(Token = "0x4004C23")]
	[FieldOffset(Offset = "0x0")]
	public static SpawnObjectCrossHairTrigger ActiveInstance;

	[Token(Token = "0x4004C24")]
	[FieldOffset(Offset = "0x10")]
	public List<int> AgainstObjectTypeList;

	[Token(Token = "0x4004C25")]
	[FieldOffset(Offset = "0x14")]
	private Dictionary<AttackableEntity, List<Collider>> m_EntityDic;

	[Token(Token = "0x4004C26")]
	[FieldOffset(Offset = "0x18")]
	private List<AttackableEntity> m_RemoveList;

	[Token(Token = "0x4004C27")]
	[FieldOffset(Offset = "0x1C")]
	private BitArray AgainstTypeFlag;

	[Token(Token = "0x6002CFC")]
	[Address(RVA = "0x21D76E4", Offset = "0x21D76E4", VA = "0x21D76E4")]
	public SpawnObjectCrossHairTrigger()
	{
	}

	[Token(Token = "0x6002CFD")]
	[Address(RVA = "0x21D77C0", Offset = "0x21D77C0", VA = "0x21D77C0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6002CFE")]
	[Address(RVA = "0x21D79D4", Offset = "0x21D79D4", VA = "0x21D79D4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6002CFF")]
	[Address(RVA = "0x21D7ADC", Offset = "0x21D7ADC", VA = "0x21D7ADC")]
	private void InitLists()
	{
	}

	[Token(Token = "0x6002D00")]
	[Address(RVA = "0x21D7A44", Offset = "0x21D7A44", VA = "0x21D7A44")]
	private void ClearLists()
	{
	}

	[Token(Token = "0x6002D01")]
	[Address(RVA = "0x21D7B9C", Offset = "0x21D7B9C", VA = "0x21D7B9C")]
	public bool HasAgainstEntities()
	{
		return default(bool);
	}

	[Token(Token = "0x6002D02")]
	[Address(RVA = "0x21D7FF8", Offset = "0x21D7FF8", VA = "0x21D7FF8")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6002D03")]
	[Address(RVA = "0x21D82BC", Offset = "0x21D82BC", VA = "0x21D82BC")]
	private void OnTriggerExit(Collider other)
	{
	}
}
