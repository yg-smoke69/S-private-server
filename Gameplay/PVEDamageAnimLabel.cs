using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2002D7E")]
internal class PVEDamageAnimLabel : MonoBehaviour
{
	[Token(Token = "0x4011748")]
	[FieldOffset(Offset = "0xC")]
	public UILabel m_Label;

	[Token(Token = "0x4011749")]
	[FieldOffset(Offset = "0x10")]
	public float[] HeadPos;

	[Token(Token = "0x401174A")]
	[FieldOffset(Offset = "0x14")]
	public bool FollowTarget;

	[Token(Token = "0x401174B")]
	[FieldOffset(Offset = "0x18")]
	public float DistanceHead;

	[Token(Token = "0x401174C")]
	[FieldOffset(Offset = "0x1C")]
	public float RedColorScale;

	[Token(Token = "0x401174D")]
	[FieldOffset(Offset = "0x20")]
	public bool DistanceReduce;

	[Token(Token = "0x401174E")]
	[FieldOffset(Offset = "0x21")]
	private bool m_IsStart;

	[Token(Token = "0x401174F")]
	[FieldOffset(Offset = "0x24")]
	private AttackableEntity m_Owner;

	[Token(Token = "0x4011750")]
	[FieldOffset(Offset = "0x28")]
	private Vector3 m_MovePos;

	[Token(Token = "0x4011751")]
	[FieldOffset(Offset = "0x34")]
	private float m_RandX;

	[Token(Token = "0x4011752")]
	[FieldOffset(Offset = "0x38")]
	private float m_RandY;

	[Token(Token = "0x4011753")]
	[FieldOffset(Offset = "0x3C")]
	private TweenScale m_Scale;

	[Token(Token = "0x4011754")]
	[FieldOffset(Offset = "0x40")]
	private TweenPosition m_LabelPos;

	[Token(Token = "0x4011755")]
	[FieldOffset(Offset = "0x44")]
	private Transform m_CachedTransform;

	[Token(Token = "0x4011756")]
	[FieldOffset(Offset = "0x48")]
	private bool m_IsUsing;

	[Token(Token = "0x4011757")]
	[FieldOffset(Offset = "0x4C")]
	private UITweener[] m_Tweeners;

	[Token(Token = "0x4011758")]
	[FieldOffset(Offset = "0x50")]
	private Vector3[] m_CacheScaleValue;

	[Token(Token = "0x4011759")]
	[FieldOffset(Offset = "0x54")]
	private bool m_StillFollow;

	[Token(Token = "0x17001383")]
	public AttackableEntity Owner
	{
		[Token(Token = "0x60130AB")]
		[Address(RVA = "0x1C77DE0", Offset = "0x1C77DE0", VA = "0x1C77DE0")]
		set
		{
		}
	}

	[Token(Token = "0x17001384")]
	public bool IsUsing
	{
		[Token(Token = "0x60130B2")]
		[Address(RVA = "0x1C78F78", Offset = "0x1C78F78", VA = "0x1C78F78")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60130AA")]
	[Address(RVA = "0x1C77CEC", Offset = "0x1C77CEC", VA = "0x1C77CEC")]
	public PVEDamageAnimLabel()
	{
	}

	[Token(Token = "0x60130AC")]
	[Address(RVA = "0x1C77DE8", Offset = "0x1C77DE8", VA = "0x1C77DE8")]
	private void Awake()
	{
	}

	[Token(Token = "0x60130AD")]
	[Address(RVA = "0x1C78270", Offset = "0x1C78270", VA = "0x1C78270")]
	private void Start()
	{
	}

	[Token(Token = "0x60130AE")]
	[Address(RVA = "0x1C78280", Offset = "0x1C78280", VA = "0x1C78280")]
	private void MoveObjecTo()
	{
	}

	[Token(Token = "0x60130AF")]
	[Address(RVA = "0x1C785EC", Offset = "0x1C785EC", VA = "0x1C785EC")]
	public float ReduceValue()
	{
		return default(float);
	}

	[Token(Token = "0x60130B0")]
	[Address(RVA = "0x1C7890C", Offset = "0x1C7890C", VA = "0x1C7890C")]
	public void SetLabelString(int score, Color color, bool followTarget = true)
	{
	}

	[Token(Token = "0x60130B1")]
	[Address(RVA = "0x1C78BA8", Offset = "0x1C78BA8", VA = "0x1C78BA8")]
	public void Reset()
	{
	}

	[Token(Token = "0x60130B3")]
	[Address(RVA = "0x1C78F80", Offset = "0x1C78F80", VA = "0x1C78F80")]
	private void Update()
	{
	}

	[Token(Token = "0x60130B4")]
	[Address(RVA = "0x1C7901C", Offset = "0x1C7901C", VA = "0x1C7901C")]
	public void OnFinished()
	{
	}
}
