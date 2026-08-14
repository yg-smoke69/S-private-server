using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003D3F")]
public class TerrainCullingSystem : MonoBehaviour
{
	[Token(Token = "0x4019FBE")]
	[FieldOffset(Offset = "0xC")]
	public float renderingDistance;

	[Token(Token = "0x4019FBF")]
	[FieldOffset(Offset = "0x10")]
	private float sphereSize;

	[Token(Token = "0x4019FC0")]
	[FieldOffset(Offset = "0x14")]
	private Terrain terrain;

	[Token(Token = "0x4019FC1")]
	[FieldOffset(Offset = "0x18")]
	private CullingGroup group;

	[Token(Token = "0x4019FC2")]
	[FieldOffset(Offset = "0x1C")]
	private BoundingSphere[] spheres;

	[Token(Token = "0x4019FC3")]
	[FieldOffset(Offset = "0x20")]
	private Vector3 offsetVector;

	[Token(Token = "0x4019FC4")]
	[FieldOffset(Offset = "0x2C")]
	private Vector3 offsetVectorUp;

	[Token(Token = "0x4019FC5")]
	[FieldOffset(Offset = "0x38")]
	private Camera mainCamera;

	[Token(Token = "0x4019FC6")]
	[FieldOffset(Offset = "0x3C")]
	private int heightSphereNumber;

	[Token(Token = "0x4019FC7")]
	[FieldOffset(Offset = "0x40")]
	public bool disableTrees;

	[Token(Token = "0x6018810")]
	[Address(RVA = "0x21DD324", Offset = "0x21DD324", VA = "0x21DD324")]
	public TerrainCullingSystem()
	{
	}

	[Token(Token = "0x6018811")]
	[Address(RVA = "0x21DD3AC", Offset = "0x21DD3AC", VA = "0x21DD3AC")]
	private void Start()
	{
	}

	[Token(Token = "0x6018812")]
	[Address(RVA = "0x21DDB90", Offset = "0x21DDB90", VA = "0x21DDB90")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6018813")]
	[Address(RVA = "0x21DDD08", Offset = "0x21DDD08", VA = "0x21DDD08")]
	private void CheckVisibility()
	{
	}

	[Token(Token = "0x6018814")]
	[Address(RVA = "0x21DDDBC", Offset = "0x21DDDBC", VA = "0x21DDDBC")]
	public void Update()
	{
	}

	[Token(Token = "0x6018815")]
	[Address(RVA = "0x21DE038", Offset = "0x21DE038", VA = "0x21DE038")]
	private void StateChangedMethod(CullingGroupEvent evt)
	{
	}

	[Token(Token = "0x6018816")]
	[Address(RVA = "0x21DE138", Offset = "0x21DE138", VA = "0x21DE138")]
	private void OnDisable()
	{
	}
}
