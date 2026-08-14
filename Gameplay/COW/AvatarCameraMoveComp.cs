using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2001FBB")]
public class AvatarCameraMoveComp : MonoBehaviour
{
	[Token(Token = "0x400C707")]
	[FieldOffset(Offset = "0xC")]
	private Vector3 lerpstart;

	[Token(Token = "0x400C708")]
	[FieldOffset(Offset = "0x18")]
	private Vector3 lerpend;

	[Token(Token = "0x400C709")]
	[FieldOffset(Offset = "0x24")]
	private float lerpbgstart;

	[Token(Token = "0x400C70A")]
	[FieldOffset(Offset = "0x28")]
	private float lerpbgend;

	[Token(Token = "0x400C70B")]
	[FieldOffset(Offset = "0x2C")]
	private Vector3 currentPos;

	[Token(Token = "0x400C70C")]
	[FieldOffset(Offset = "0x38")]
	private float currentBgPos;

	[Token(Token = "0x400C70D")]
	[FieldOffset(Offset = "0x3C")]
	private GameObject BgObj;

	[Token(Token = "0x400C70E")]
	[FieldOffset(Offset = "0x40")]
	private GameObject CameraObj;

	[Token(Token = "0x400C70F")]
	[FieldOffset(Offset = "0x44")]
	public float currentmovetime;

	[Token(Token = "0x400C710")]
	[FieldOffset(Offset = "0x48")]
	private bool IsMoving;

	[Token(Token = "0x400C711")]
	[FieldOffset(Offset = "0x4C")]
	private float m_Movetime;

	[Token(Token = "0x400C712")]
	[FieldOffset(Offset = "0x50")]
	private float m_orignbg;

	[Token(Token = "0x400C713")]
	[FieldOffset(Offset = "0x54")]
	private Vector3 m_orignpos;

	[Token(Token = "0x6009EAA")]
	[Address(RVA = "0x10FC038", Offset = "0x10FC038", VA = "0x10FC038")]
	public AvatarCameraMoveComp()
	{
	}

	[Token(Token = "0x6009EAB")]
	[Address(RVA = "0x10FC04C", Offset = "0x10FC04C", VA = "0x10FC04C")]
	public void SetOriginInfo(Vector3 prePos, float preBgSize, GameObject bgObj, GameObject camObj, float moveDuration = 1f)
	{
	}

	[Token(Token = "0x6009EAC")]
	[Address(RVA = "0x10FC114", Offset = "0x10FC114", VA = "0x10FC114")]
	public void SetLerpInfo(GameObject obj, GameObject camera, Vector3 start, Vector3 end, float bgstart, float bgend)
	{
	}

	[Token(Token = "0x6009EAD")]
	[Address(RVA = "0x10FC20C", Offset = "0x10FC20C", VA = "0x10FC20C")]
	public void SetSimpleLerpInfo(Vector3 start, Vector3 end, float bgstart, float bgend)
	{
	}

	[Token(Token = "0x6009EAE")]
	[Address(RVA = "0x10FC2E4", Offset = "0x10FC2E4", VA = "0x10FC2E4")]
	public void SetMoveing()
	{
	}

	[Token(Token = "0x6009EAF")]
	[Address(RVA = "0x10FC358", Offset = "0x10FC358", VA = "0x10FC358")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6009EB0")]
	[Address(RVA = "0x10FC3AC", Offset = "0x10FC3AC", VA = "0x10FC3AC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6009EB1")]
	[Address(RVA = "0x10FC5E8", Offset = "0x10FC5E8", VA = "0x10FC5E8")]
	private void Update()
	{
	}
}
