using GCommon;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000788")]
public class DropObject : MonoBehaviour
{
	[Token(Token = "0x2000789")]
	private struct ShadowState
	{
		[Token(Token = "0x4004E81")]
		[FieldOffset(Offset = "0x0")]
		public Vector3 TargetPos;

		[Token(Token = "0x4004E82")]
		[FieldOffset(Offset = "0xC")]
		public Quaternion TargetRot;

		[Token(Token = "0x4004E83")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 StartPos;

		[Token(Token = "0x4004E84")]
		[FieldOffset(Offset = "0x28")]
		public Quaternion StartRot;
	}

	[Token(Token = "0x4004E6A")]
	[FieldOffset(Offset = "0xC")]
	public uint Guid;

	[Token(Token = "0x4004E6B")]
	[FieldOffset(Offset = "0x10")]
	public GameObject model;

	[Token(Token = "0x4004E6C")]
	[FieldOffset(Offset = "0x14")]
	public Transform shadow;

	[Token(Token = "0x4004E6D")]
	[FieldOffset(Offset = "0x18")]
	private readonly float startScale;

	[Token(Token = "0x4004E6E")]
	[FieldOffset(Offset = "0x1C")]
	private readonly float endScale;

	[Token(Token = "0x4004E6F")]
	[FieldOffset(Offset = "0x20")]
	private readonly float totalTime;

	[Token(Token = "0x4004E70")]
	[FieldOffset(Offset = "0x24")]
	private readonly float minSpeed;

	[Token(Token = "0x4004E71")]
	[FieldOffset(Offset = "0x28")]
	public readonly string ShadowName;

	[Token(Token = "0x4004E72")]
	[FieldOffset(Offset = "0x2C")]
	private float curTime;

	[Token(Token = "0x4004E73")]
	[FieldOffset(Offset = "0x30")]
	private bool changeShadowScale;

	[Token(Token = "0x4004E74")]
	[FieldOffset(Offset = "0x34")]
	private Vector3 shadowPos;

	[Token(Token = "0x4004E75")]
	[FieldOffset(Offset = "0x40")]
	private ResourceID resID;

	[Token(Token = "0x4004E76")]
	[FieldOffset(Offset = "0x44")]
	private Vector3 position;

	[Token(Token = "0x4004E77")]
	[FieldOffset(Offset = "0x50")]
	private Quaternion rotation;

	[Token(Token = "0x4004E78")]
	[FieldOffset(Offset = "0x60")]
	private Vector3 scale;

	[Token(Token = "0x4004E79")]
	[FieldOffset(Offset = "0x6C")]
	protected Vector3 m_LastVelocity;

	[Token(Token = "0x4004E7A")]
	[FieldOffset(Offset = "0x78")]
	private bool landed;

	[Token(Token = "0x4004E7B")]
	[FieldOffset(Offset = "0x7C")]
	private ShadowState m_ShadowState;

	[Token(Token = "0x4004E7C")]
	[FieldOffset(Offset = "0xB4")]
	protected uint m_LastValidTickCount;

	[Token(Token = "0x4004E7D")]
	[FieldOffset(Offset = "0xB8")]
	private uint TargetTickCount;

	[Token(Token = "0x4004E7E")]
	[FieldOffset(Offset = "0xBC")]
	private uint SimTick;

	[Token(Token = "0x4004E7F")]
	[FieldOffset(Offset = "0xC0")]
	private GameObject m_AudioSource;

	[Token(Token = "0x4004E80")]
	[FieldOffset(Offset = "0xC4")]
	private bool IsStatic;

	[Token(Token = "0x1700039B")]
	public Vector3 Position
	{
		[Token(Token = "0x600305F")]
		[Address(RVA = "0x23249EC", Offset = "0x23249EC", VA = "0x23249EC")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}
		[Token(Token = "0x6003060")]
		[Address(RVA = "0x2324B04", Offset = "0x2324B04", VA = "0x2324B04")]
		set
		{
		}
	}

	[Token(Token = "0x1700039C")]
	public Quaternion Rotation
	{
		[Token(Token = "0x6003061")]
		[Address(RVA = "0x2324BFC", Offset = "0x2324BFC", VA = "0x2324BFC")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Quaternion);
		}
		[Token(Token = "0x6003062")]
		[Address(RVA = "0x2324D14", Offset = "0x2324D14", VA = "0x2324D14")]
		set
		{
		}
	}

	[Token(Token = "0x600305E")]
	[Address(RVA = "0x23248F8", Offset = "0x23248F8", VA = "0x23248F8")]
	public DropObject()
	{
	}

	[Token(Token = "0x6003063")]
	[Address(RVA = "0x2324E14", Offset = "0x2324E14", VA = "0x2324E14")]
	public void InitDropObject(uint id, ResourceID _resID, Vector3 _position, Quaternion _rotation, Vector3 _scale, Vector3 _speed)
	{
	}

	[Token(Token = "0x6003064")]
	[Address(RVA = "0x2324E78", Offset = "0x2324E78", VA = "0x2324E78")]
	private void Clear()
	{
	}

	[Token(Token = "0x6003065")]
	[Address(RVA = "0x2324FE0", Offset = "0x2324FE0", VA = "0x2324FE0")]
	public void PlaySound(ResourceID resourceID)
	{
	}

	[Token(Token = "0x6003066")]
	[Address(RVA = "0x23251BC", Offset = "0x23251BC", VA = "0x23251BC")]
	public void ShowModel(GameObject go)
	{
	}

	[Token(Token = "0x6003067")]
	[Address(RVA = "0x2325664", Offset = "0x2325664", VA = "0x2325664")]
	private void ShowShadow()
	{
	}

	[Token(Token = "0x6003068")]
	[Address(RVA = "0x2325AFC", Offset = "0x2325AFC", VA = "0x2325AFC")]
	public void Update()
	{
	}

	[Token(Token = "0x6003069")]
	[Address(RVA = "0x2325F8C", Offset = "0x2325F8C", VA = "0x2325F8C")]
	public void SyncPos(uint tickCount, Vector3 _position, Quaternion _rotation, Vector3 _speed)
	{
	}

	[Token(Token = "0x600306A")]
	[Address(RVA = "0x232605C", Offset = "0x232605C", VA = "0x232605C")]
	public void Destroy()
	{
	}
}
