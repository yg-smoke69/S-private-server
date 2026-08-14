using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2001E9D")]
public class TweenPositionArc : MonoBehaviour
{
	[Token(Token = "0x2001E9E")]
	public enum Quadrant
	{
		[Token(Token = "0x400C075")]
		None,
		[Token(Token = "0x400C076")]
		First,
		[Token(Token = "0x400C077")]
		Second,
		[Token(Token = "0x400C078")]
		Third,
		[Token(Token = "0x400C079")]
		Fourth
	}

	[Token(Token = "0x400C06A")]
	[FieldOffset(Offset = "0xC")]
	private Vector3 mStartPos;

	[Token(Token = "0x400C06B")]
	[FieldOffset(Offset = "0x18")]
	private Vector3 mEndPos;

	[Token(Token = "0x400C06C")]
	[FieldOffset(Offset = "0x24")]
	private float mF1;

	[Token(Token = "0x400C06D")]
	[FieldOffset(Offset = "0x28")]
	private float mF2;

	[Token(Token = "0x400C06E")]
	[FieldOffset(Offset = "0x2C")]
	private float mTime;

	[Token(Token = "0x400C06F")]
	[FieldOffset(Offset = "0x30")]
	private float mSpeed;

	[Token(Token = "0x400C070")]
	[FieldOffset(Offset = "0x34")]
	private int mIndex;

	[Token(Token = "0x400C071")]
	[FieldOffset(Offset = "0x38")]
	private float mDelay;

	[Token(Token = "0x400C072")]
	[FieldOffset(Offset = "0x3C")]
	private bool mPlay;

	[Token(Token = "0x400C073")]
	[FieldOffset(Offset = "0x3D")]
	private bool mStop;

	[Token(Token = "0x60093CA")]
	[Address(RVA = "0x2335CA4", Offset = "0x2335CA4", VA = "0x2335CA4")]
	public TweenPositionArc()
	{
	}

	[Token(Token = "0x60093CB")]
	[Address(RVA = "0x2335CB4", Offset = "0x2335CB4", VA = "0x2335CB4")]
	private void Update()
	{
	}

	[Token(Token = "0x60093CC")]
	[Address(RVA = "0x2336300", Offset = "0x2336300", VA = "0x2336300")]
	private void SetFactor()
	{
	}

	[Token(Token = "0x60093CD")]
	[Address(RVA = "0x2336388", Offset = "0x2336388", VA = "0x2336388")]
	private void SetFactor(Quadrant quadrant)
	{
	}

	[Token(Token = "0x60093CE")]
	[Address(RVA = "0x2336660", Offset = "0x2336660", VA = "0x2336660")]
	private void SetFactor(float dis)
	{
	}

	[Token(Token = "0x60093CF")]
	[Address(RVA = "0x2336868", Offset = "0x2336868", VA = "0x2336868")]
	public void StartAnimation(Vector3 startPos, Vector3 endPos, float speed = 1f, float dis = 0f, Quadrant quadrant = Quadrant.None, bool randomFactor = true, int index = 0, float delay = 0f)
	{
	}

	[Token(Token = "0x60093D0")]
	[Address(RVA = "0x233610C", Offset = "0x233610C", VA = "0x233610C")]
	private void StopAnimation()
	{
	}
}
