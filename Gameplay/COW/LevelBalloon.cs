using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20005DB")]
public class LevelBalloon : MonoBehaviour
{
	[Token(Token = "0x4004438")]
	[FieldOffset(Offset = "0xC")]
	private LinkedListNode<LevelBalloon> m_node;

	[Token(Token = "0x4004439")]
	[FieldOffset(Offset = "0x10")]
	private bool isInit;

	[Token(Token = "0x400443A")]
	[FieldOffset(Offset = "0x14")]
	private readonly float upSpeed;

	[Token(Token = "0x400443B")]
	[FieldOffset(Offset = "0x18")]
	private readonly float maxLifeTime;

	[Token(Token = "0x400443C")]
	[FieldOffset(Offset = "0x1C")]
	private float lifeTime;

	[Token(Token = "0x400443D")]
	[FieldOffset(Offset = "0x20")]
	private ResourceID m_Resource;

	[Token(Token = "0x600235F")]
	[Address(RVA = "0x1EFB98C", Offset = "0x1EFB98C", VA = "0x1EFB98C")]
	public LevelBalloon()
	{
	}

	[Token(Token = "0x6002360")]
	[Address(RVA = "0x1EFBA40", Offset = "0x1EFBA40", VA = "0x1EFBA40")]
	private void Start()
	{
	}

	[Token(Token = "0x6002361")]
	[Address(RVA = "0x1EFBA94", Offset = "0x1EFBA94", VA = "0x1EFBA94")]
	private void Update()
	{
	}

	[Token(Token = "0x6002362")]
	[Address(RVA = "0x1EFBE08", Offset = "0x1EFBE08", VA = "0x1EFBE08")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6002363")]
	[Address(RVA = "0x1EFBF74", Offset = "0x1EFBF74", VA = "0x1EFBF74")]
	public void Init(LinkedListNode<LevelBalloon> node, ResourceID resource)
	{
	}

	[Token(Token = "0x6002364")]
	[Address(RVA = "0x1EFBC60", Offset = "0x1EFBC60", VA = "0x1EFBC60")]
	public void BalloonDestroy()
	{
	}
}
