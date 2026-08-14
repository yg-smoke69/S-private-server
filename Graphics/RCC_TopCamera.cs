using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003BC4")]
public class RCC_TopCamera : MonoBehaviour
{
	[Token(Token = "0x401978B")]
	[FieldOffset(Offset = "0xC")]
	public Transform playerCar;

	[Token(Token = "0x401978C")]
	[FieldOffset(Offset = "0x10")]
	private Rigidbody playerRigid;

	[Token(Token = "0x401978D")]
	[FieldOffset(Offset = "0x14")]
	private Camera cam;

	[Token(Token = "0x401978E")]
	[FieldOffset(Offset = "0x18")]
	public GameObject pivot;

	[Token(Token = "0x401978F")]
	[FieldOffset(Offset = "0x1C")]
	public float distance;

	[Token(Token = "0x4019790")]
	[FieldOffset(Offset = "0x20")]
	private float distanceOffset;

	[Token(Token = "0x4019791")]
	[FieldOffset(Offset = "0x24")]
	public float maximumDistanceOffset;

	[Token(Token = "0x4019792")]
	[FieldOffset(Offset = "0x28")]
	private float targetFieldOfView;

	[Token(Token = "0x4019793")]
	[FieldOffset(Offset = "0x2C")]
	public float minimumOrtSize;

	[Token(Token = "0x4019794")]
	[FieldOffset(Offset = "0x30")]
	public float maximumOrtSize;

	[Token(Token = "0x4019795")]
	[FieldOffset(Offset = "0x34")]
	private Vector3 targetPosition;

	[Token(Token = "0x4019796")]
	[FieldOffset(Offset = "0x40")]
	private Vector3 pastFollowerPosition;

	[Token(Token = "0x4019797")]
	[FieldOffset(Offset = "0x4C")]
	private Vector3 pastTargetPosition;

	[Token(Token = "0x4019798")]
	[FieldOffset(Offset = "0x58")]
	private float speed;

	[Token(Token = "0x170018DB")]
	public Transform _playerCar
	{
		[Token(Token = "0x6017D84")]
		[Address(RVA = "0x1E3C880", Offset = "0x1E3C880", VA = "0x1E3C880")]
		get
		{
			return null;
		}
		[Token(Token = "0x6017D85")]
		[Address(RVA = "0x1E3C888", Offset = "0x1E3C888", VA = "0x1E3C888")]
		set
		{
		}
	}

	[Token(Token = "0x6017D83")]
	[Address(RVA = "0x1E3C790", Offset = "0x1E3C790", VA = "0x1E3C790")]
	public RCC_TopCamera()
	{
	}

	[Token(Token = "0x6017D86")]
	[Address(RVA = "0x1E3CA88", Offset = "0x1E3CA88", VA = "0x1E3CA88")]
	private void Awake()
	{
	}

	[Token(Token = "0x6017D87")]
	[Address(RVA = "0x1E3C890", Offset = "0x1E3C890", VA = "0x1E3C890")]
	private void GetPlayerCar()
	{
	}

	[Token(Token = "0x6017D88")]
	[Address(RVA = "0x1E3CAF0", Offset = "0x1E3CAF0", VA = "0x1E3CAF0")]
	public void SetPlayerCar(GameObject player)
	{
	}

	[Token(Token = "0x6017D89")]
	[Address(RVA = "0x1E3CB2C", Offset = "0x1E3CB2C", VA = "0x1E3CB2C")]
	private void Update()
	{
	}

	[Token(Token = "0x6017D8A")]
	[Address(RVA = "0x1E3D014", Offset = "0x1E3D014", VA = "0x1E3D014")]
	private Vector3 SmoothApproach(Vector3 pastPosition, Vector3 pastTargetPosition, Vector3 targetPosition, float delta)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}
}
