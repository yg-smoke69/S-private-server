using GCommon;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000796")]
public class SpeedObject : MonoBehaviour
{
	[Token(Token = "0x2000797")]
	private struct ShadowState
	{
		[Token(Token = "0x4004EBF")]
		[FieldOffset(Offset = "0x0")]
		public Vector3 TargetPos;

		[Token(Token = "0x4004EC0")]
		[FieldOffset(Offset = "0xC")]
		public Quaternion TargetRot;

		[Token(Token = "0x4004EC1")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 StartPos;

		[Token(Token = "0x4004EC2")]
		[FieldOffset(Offset = "0x28")]
		public Quaternion StartRot;
	}

	[Token(Token = "0x4004EB3")]
	[FieldOffset(Offset = "0xC")]
	public uint Guid;

	[Token(Token = "0x4004EB4")]
	[FieldOffset(Offset = "0x10")]
	public GameObject model;

	[Token(Token = "0x4004EB5")]
	[FieldOffset(Offset = "0x14")]
	private ResourceID resID;

	[Token(Token = "0x4004EB6")]
	[FieldOffset(Offset = "0x18")]
	private Vector3 position;

	[Token(Token = "0x4004EB7")]
	[FieldOffset(Offset = "0x24")]
	private Quaternion rotation;

	[Token(Token = "0x4004EB8")]
	[FieldOffset(Offset = "0x34")]
	private Vector3 scale;

	[Token(Token = "0x4004EB9")]
	[FieldOffset(Offset = "0x40")]
	protected Vector3 m_LastVelocity;

	[Token(Token = "0x4004EBA")]
	[FieldOffset(Offset = "0x4C")]
	private ShadowState m_ShadowState;

	[Token(Token = "0x4004EBB")]
	[FieldOffset(Offset = "0x84")]
	protected uint m_LastValidTickCount;

	[Token(Token = "0x4004EBC")]
	[FieldOffset(Offset = "0x88")]
	private uint TargetTickCount;

	[Token(Token = "0x4004EBD")]
	[FieldOffset(Offset = "0x8C")]
	private uint SimTick;

	[Token(Token = "0x4004EBE")]
	[FieldOffset(Offset = "0x90")]
	private GameObject m_AudioSource;

	[Token(Token = "0x1700039E")]
	public Vector3 Position
	{
		[Token(Token = "0x600308F")]
		[Address(RVA = "0x21D8788", Offset = "0x21D8788", VA = "0x21D8788")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}
		[Token(Token = "0x6003090")]
		[Address(RVA = "0x21D88A0", Offset = "0x21D88A0", VA = "0x21D88A0")]
		set
		{
		}
	}

	[Token(Token = "0x1700039F")]
	public Quaternion Rotation
	{
		[Token(Token = "0x6003091")]
		[Address(RVA = "0x21D8998", Offset = "0x21D8998", VA = "0x21D8998")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Quaternion);
		}
		[Token(Token = "0x6003092")]
		[Address(RVA = "0x21D8AB0", Offset = "0x21D8AB0", VA = "0x21D8AB0")]
		set
		{
		}
	}

	[Token(Token = "0x600308E")]
	[Address(RVA = "0x21D86E4", Offset = "0x21D86E4", VA = "0x21D86E4")]
	public SpeedObject()
	{
	}

	[Token(Token = "0x6003093")]
	[Address(RVA = "0x21D8BB0", Offset = "0x21D8BB0", VA = "0x21D8BB0")]
	public void InitObject(uint id, ResourceID _resID, Vector3 _position, Quaternion _rotation, Vector3 _scale, Vector3 _speed)
	{
	}

	[Token(Token = "0x6003094")]
	[Address(RVA = "0x21D8C14", Offset = "0x21D8C14", VA = "0x21D8C14")]
	private void Clear()
	{
	}

	[Token(Token = "0x6003095")]
	[Address(RVA = "0x21D8D54", Offset = "0x21D8D54", VA = "0x21D8D54")]
	public void PlaySound(ResourceID resourceID)
	{
	}

	[Token(Token = "0x6003096")]
	[Address(RVA = "0x21D8F30", Offset = "0x21D8F30", VA = "0x21D8F30")]
	public void ShowModel(GameObject go)
	{
	}

	[Token(Token = "0x6003097")]
	[Address(RVA = "0x21D9284", Offset = "0x21D9284", VA = "0x21D9284")]
	public void Update()
	{
	}

	[Token(Token = "0x6003098")]
	[Address(RVA = "0x21D9434", Offset = "0x21D9434", VA = "0x21D9434")]
	public void SyncPos(uint tickCount, Vector3 _position, Quaternion _rotation, Vector3 _speed)
	{
	}

	[Token(Token = "0x6003099")]
	[Address(RVA = "0x21D9504", Offset = "0x21D9504", VA = "0x21D9504")]
	public void Destroy()
	{
	}
}
