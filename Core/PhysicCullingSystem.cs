using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003D16")]
public class PhysicCullingSystem : MonoBehaviour
{
	[Token(Token = "0x4019EA9")]
	[FieldOffset(Offset = "0xC")]
	public float physicDistance;

	[Token(Token = "0x4019EAA")]
	[FieldOffset(Offset = "0x10")]
	private float sphereSize;

	[Token(Token = "0x4019EAB")]
	[FieldOffset(Offset = "0x14")]
	private Rigidbody rigidbody;

	[Token(Token = "0x4019EAC")]
	[FieldOffset(Offset = "0x18")]
	private CullingGroup group;

	[Token(Token = "0x4019EAD")]
	[FieldOffset(Offset = "0x1C")]
	private BoundingSphere[] spheres;

	[Token(Token = "0x4019EAE")]
	[FieldOffset(Offset = "0x20")]
	private Camera mainCamera;

	[Token(Token = "0x4019EAF")]
	[FieldOffset(Offset = "0x24")]
	public Vector3 velocity;

	[Token(Token = "0x4019EB0")]
	[FieldOffset(Offset = "0x30")]
	public Vector3 angularVelocity;

	[Token(Token = "0x4019EB1")]
	[FieldOffset(Offset = "0x3C")]
	public bool gizmo;

	[Token(Token = "0x6018758")]
	[Address(RVA = "0x1C7AA28", Offset = "0x1C7AA28", VA = "0x1C7AA28")]
	public PhysicCullingSystem()
	{
	}

	[Token(Token = "0x6018759")]
	[Address(RVA = "0x1C7AAB8", Offset = "0x1C7AAB8", VA = "0x1C7AAB8")]
	private void Start()
	{
	}

	[Token(Token = "0x601875A")]
	[Address(RVA = "0x1C7ADAC", Offset = "0x1C7ADAC", VA = "0x1C7ADAC")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x601875B")]
	[Address(RVA = "0x1C7AE30", Offset = "0x1C7AE30", VA = "0x1C7AE30")]
	private void CheckVisibility()
	{
	}

	[Token(Token = "0x601875C")]
	[Address(RVA = "0x1C7AF24", Offset = "0x1C7AF24", VA = "0x1C7AF24")]
	public void Update()
	{
	}

	[Token(Token = "0x601875D")]
	[Address(RVA = "0x1C7B094", Offset = "0x1C7B094", VA = "0x1C7B094")]
	private void StateChangedMethod(CullingGroupEvent evt)
	{
	}

	[Token(Token = "0x601875E")]
	[Address(RVA = "0x1C7B184", Offset = "0x1C7B184", VA = "0x1C7B184")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x601875F")]
	[Address(RVA = "0x1C7B0E4", Offset = "0x1C7B0E4", VA = "0x1C7B0E4")]
	private void StopMovement()
	{
	}

	[Token(Token = "0x6018760")]
	[Address(RVA = "0x1C7AE74", Offset = "0x1C7AE74", VA = "0x1C7AE74")]
	private void StartMovement()
	{
	}
}
