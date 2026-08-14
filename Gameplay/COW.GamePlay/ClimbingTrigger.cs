using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x20005BC")]
public class ClimbingTrigger : MonoBehaviour
{
	[Token(Token = "0x40043A4")]
	[FieldOffset(Offset = "0xC")]
	public bool NeedDrawCustomGizmo;

	[Token(Token = "0x40043A5")]
	[FieldOffset(Offset = "0x10")]
	private BoxCollider ABLAOAPPBGF;

	[Token(Token = "0x40043A6")]
	[FieldOffset(Offset = "0x14")]
	private float GHLDEFCDIBA;

	[Token(Token = "0x40043A7")]
	[FieldOffset(Offset = "0x18")]
	public CAMFLKNHOFB TriggerType;

	[Token(Token = "0x40043A8")]
	[FieldOffset(Offset = "0x1C")]
	public float AngleRange;

	[Token(Token = "0x40043A9")]
	[FieldOffset(Offset = "0x20")]
	public float CrossLength;

	[Token(Token = "0x40043AA")]
	[FieldOffset(Offset = "0x24")]
	public float CrossHeight;

	[Token(Token = "0x40043AB")]
	[FieldOffset(Offset = "0x28")]
	public string TriggerTag;

	[Token(Token = "0x40043AC")]
	[FieldOffset(Offset = "0x2C")]
	private float FHLMNFCKNBH;

	[Token(Token = "0x40043AD")]
	[FieldOffset(Offset = "0x30")]
	private bool HODAMMKGHKH;

	[Token(Token = "0x40043AE")]
	[FieldOffset(Offset = "0x34")]
	private Vector3 NLHHMPDOJOM;

	[Token(Token = "0x40043AF")]
	[FieldOffset(Offset = "0x40")]
	public uint TriggerUniqueID;

	[Token(Token = "0x40043B0")]
	[FieldOffset(Offset = "0x44")]
	public bool TriggerEnable;

	[Token(Token = "0x40043B1")]
	[FieldOffset(Offset = "0x48")]
	private LevelClimbingTrigger BLKJHFADCHF;

	[Token(Token = "0x170002D8")]
	public BoxCollider GILBHHDNOAA
	{
		[Token(Token = "0x60022CB")]
		[Address(RVA = "0x1E9D874", Offset = "0x1E9D874", VA = "0x1E9D874")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002D9")]
	public Vector3 EJHAOBBFPLF
	{
		[Token(Token = "0x60022CC")]
		[Address(RVA = "0x1E9D970", Offset = "0x1E9D970", VA = "0x1E9D970")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}
	}

	[Token(Token = "0x170002DA")]
	public float BJGMJDOHFOH
	{
		[Token(Token = "0x60022CD")]
		[Address(RVA = "0x1E9DA00", Offset = "0x1E9DA00", VA = "0x1E9DA00")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170002DB")]
	public Vector3 CJLIEDJPKOJ
	{
		[Token(Token = "0x60022CE")]
		[Address(RVA = "0x1E9DA58", Offset = "0x1E9DA58", VA = "0x1E9DA58")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}
	}

	[Token(Token = "0x60022CA")]
	[Address(RVA = "0x1E9D7A0", Offset = "0x1E9D7A0", VA = "0x1E9D7A0")]
	public ClimbingTrigger()
	{
	}

	[Token(Token = "0x60022CF")]
	[Address(RVA = "0x1E9DD18", Offset = "0x1E9DD18", VA = "0x1E9DD18")]
	private void Start()
	{
	}

	[Token(Token = "0x60022D0")]
	[Address(RVA = "0x1E9DAD8", Offset = "0x1E9DAD8", VA = "0x1E9DAD8")]
	public void ReCaculateTargetPosition()
	{
	}

	[Token(Token = "0x60022D1")]
	[Address(RVA = "0x1E9E024", Offset = "0x1E9E024", VA = "0x1E9E024")]
	public float GetCrossHeight()
	{
		return default(float);
	}

	[Token(Token = "0x60022D2")]
	[Address(RVA = "0x1E9E110", Offset = "0x1E9E110", VA = "0x1E9E110")]
	public void CalcFixCrossHeight()
	{
	}
}
