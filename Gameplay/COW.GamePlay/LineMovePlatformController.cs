using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x20006F6")]
public class LineMovePlatformController : MovePlatformController
{
	[Serializable]
	[Token(Token = "0x20006F7")]
	public class MoveData
	{
		[Token(Token = "0x4004BA6")]
		[FieldOffset(Offset = "0x8")]
		public Transform m_MovePlatform;

		[Token(Token = "0x4004BA7")]
		[FieldOffset(Offset = "0xC")]
		public float m_MoveSpeed;

		[Token(Token = "0x4004BA8")]
		[FieldOffset(Offset = "0x10")]
		public bool m_IsNeedLoop;

		[Token(Token = "0x4004BA9")]
		[FieldOffset(Offset = "0x11")]
		public bool m_IsFaceToFoward;

		[Token(Token = "0x4004BAA")]
		[FieldOffset(Offset = "0x14")]
		public float m_RotSpeed;

		[Token(Token = "0x4004BAB")]
		[FieldOffset(Offset = "0x18")]
		public bool m_IsHitKillPlayer;

		[Token(Token = "0x4004BAC")]
		[FieldOffset(Offset = "0x19")]
		public bool EndToTurn;

		[Token(Token = "0x4004BAD")]
		[FieldOffset(Offset = "0x1C")]
		public List<Transform> m_MoveLine;

		[Token(Token = "0x4004BAE")]
		[FieldOffset(Offset = "0x20")]
		public int curTargetNodeIndex;

		[Token(Token = "0x4004BAF")]
		[FieldOffset(Offset = "0x24")]
		public bool isMovingForward;

		[Token(Token = "0x4004BB0")]
		[FieldOffset(Offset = "0x25")]
		public bool isArrive;

		[Token(Token = "0x4004BB1")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 curMoveDirection;

		[Token(Token = "0x4004BB2")]
		[FieldOffset(Offset = "0x34")]
		public Transform pathNodeRoot;

		[Token(Token = "0x6002C8D")]
		[Address(RVA = "0x2443630", Offset = "0x2443630", VA = "0x2443630")]
		public MoveData()
		{
		}
	}

	[Token(Token = "0x4004BA4")]
	[FieldOffset(Offset = "0xC")]
	public List<MoveData> moveDataList;

	[Token(Token = "0x4004BA5")]
	[FieldOffset(Offset = "0x10")]
	private bool OLIBGKIGPOI;

	[Token(Token = "0x6002C82")]
	[Address(RVA = "0x2442010", Offset = "0x2442010", VA = "0x2442010")]
	public LineMovePlatformController()
	{
	}

	[Token(Token = "0x6002C83")]
	[Address(RVA = "0x244209C", Offset = "0x244209C", VA = "0x244209C")]
	private void Start()
	{
	}

	[Token(Token = "0x6002C84")]
	[Address(RVA = "0x244237C", Offset = "0x244237C", VA = "0x244237C")]
	public void ResetMoveInEdiotr(bool JNPFPPNOLGP)
	{
	}

	[Token(Token = "0x6002C85")]
	[Address(RVA = "0x244282C", Offset = "0x244282C", VA = "0x244282C")]
	private void Update()
	{
	}

	[Token(Token = "0x6002C86")]
	[Address(RVA = "0x244288C", Offset = "0x244288C", VA = "0x244288C")]
	public void UpdateClientMove()
	{
	}

	[Token(Token = "0x6002C87")]
	[Address(RVA = "0x24432E0", Offset = "0x24432E0", VA = "0x24432E0")]
	public void CreateMoveData()
	{
	}

	[Token(Token = "0x6002C88")]
	[Address(RVA = "0x24436C4", Offset = "0x24436C4", VA = "0x24436C4")]
	public void RefreshPathNode()
	{
	}

	[Token(Token = "0x6002C89")]
	[Address(RVA = "0x24421F8", Offset = "0x24421F8", VA = "0x24421F8")]
	public void ClearAll()
	{
	}

	[Token(Token = "0x6002C8A")]
	[Address(RVA = "0x2443AA0", Offset = "0x2443AA0", VA = "0x2443AA0")]
	public void ClearMovePlatform()
	{
	}

	[Token(Token = "0x6002C8B")]
	[Address(RVA = "0x244318C", Offset = "0x244318C", VA = "0x244318C")]
	public Quaternion LookRotation(Vector3 DGINHHNABED)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Quaternion);
	}

	[Token(Token = "0x6002C8C")]
	[Address(RVA = "0x2443CE8", Offset = "0x2443CE8", VA = "0x2443CE8")]
	private Quaternion LIAFKMAJPDO(Vector3 EBIJHALKJEM, Vector3 CNACGBKBBIJ)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Quaternion);
	}
}
