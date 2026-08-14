using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20023E7")]
public class TurntableAnim : MonoBehaviour
{
	[Token(Token = "0x20023E8")]
	private enum CircleStage
	{
		[Token(Token = "0x400DF2B")]
		NORMAL_RUNNING,
		[Token(Token = "0x400DF2C")]
		BACK,
		[Token(Token = "0x400DF2D")]
		END
	}

	[Token(Token = "0x20023E9")]
	private class RewardIdx
	{
		[Token(Token = "0x400DF2E")]
		[FieldOffset(Offset = "0x8")]
		public int idx;

		[Token(Token = "0x400DF2F")]
		[FieldOffset(Offset = "0xC")]
		public int iterationIdx;

		[Token(Token = "0x600CAB3")]
		[Address(RVA = "0x26473C8", Offset = "0x26473C8", VA = "0x26473C8")]
		public RewardIdx()
		{
		}
	}

	[Token(Token = "0x20023EA")]
	private class RateCurve
	{
		[Token(Token = "0x400DF30")]
		[FieldOffset(Offset = "0x8")]
		public float a;

		[Token(Token = "0x400DF31")]
		[FieldOffset(Offset = "0xC")]
		public int powers;

		[Token(Token = "0x400DF32")]
		[FieldOffset(Offset = "0x10")]
		public float endY;

		[Token(Token = "0x600CAB4")]
		[Address(RVA = "0x2646F78", Offset = "0x2646F78", VA = "0x2646F78")]
		public RateCurve()
		{
		}
	}

	[Token(Token = "0x400DF18")]
	[FieldOffset(Offset = "0xC")]
	private List<RewardIdx> m_RewardIdxList;

	[Token(Token = "0x400DF19")]
	[FieldOffset(Offset = "0x10")]
	private int m_IterationCounter;

	[Token(Token = "0x400DF1A")]
	private const int TURNTABLE_REWARD_CNT = 7;

	[Token(Token = "0x400DF1B")]
	private const float ROTATE_ANGLE = 51.42857f;

	[Token(Token = "0x400DF1C")]
	[FieldOffset(Offset = "0x14")]
	private bool doCircle;

	[Token(Token = "0x400DF1D")]
	[FieldOffset(Offset = "0x18")]
	private Vector3 lastRotate;

	[Token(Token = "0x400DF1E")]
	[FieldOffset(Offset = "0x24")]
	private float leap;

	[Token(Token = "0x400DF1F")]
	[FieldOffset(Offset = "0x28")]
	private bool startBack;

	[Token(Token = "0x400DF20")]
	[FieldOffset(Offset = "0x2C")]
	public int circle_cnt;

	[Token(Token = "0x400DF21")]
	[FieldOffset(Offset = "0x30")]
	public int direction;

	[Token(Token = "0x400DF22")]
	[FieldOffset(Offset = "0x34")]
	public float maxDuration;

	[Token(Token = "0x400DF23")]
	[FieldOffset(Offset = "0x38")]
	public float minDuration;

	[Token(Token = "0x400DF24")]
	[FieldOffset(Offset = "0x3C")]
	public int powers;

	[Token(Token = "0x400DF25")]
	[FieldOffset(Offset = "0x40")]
	public bool needBack;

	[Token(Token = "0x400DF26")]
	[FieldOffset(Offset = "0x44")]
	public float backDuration;

	[Token(Token = "0x400DF27")]
	[FieldOffset(Offset = "0x48")]
	public float backDelay;

	[Token(Token = "0x400DF28")]
	[FieldOffset(Offset = "0x4C")]
	private RateCurve m_Curve;

	[Token(Token = "0x400DF29")]
	[FieldOffset(Offset = "0x50")]
	private List<uint> m_IDList;

	[Token(Token = "0x600CAA8")]
	[Address(RVA = "0x2646E44", Offset = "0x2646E44", VA = "0x2646E44")]
	public TurntableAnim()
	{
	}

	[Token(Token = "0x600CAA9")]
	[Address(RVA = "0x2646F88", Offset = "0x2646F88", VA = "0x2646F88")]
	public void DoCircle(List<uint> idList)
	{
	}

	[Token(Token = "0x600CAAA")]
	[Address(RVA = "0x2646FA8", Offset = "0x2646FA8", VA = "0x2646FA8")]
	private void InitData()
	{
	}

	[Token(Token = "0x600CAAB")]
	[Address(RVA = "0x264709C", Offset = "0x264709C", VA = "0x264709C")]
	private void GenRewardIndexList()
	{
	}

	[Token(Token = "0x600CAAC")]
	[Address(RVA = "0x2647290", Offset = "0x2647290", VA = "0x2647290")]
	private void BuildLapRateCurve()
	{
	}

	[Token(Token = "0x600CAAD")]
	[Address(RVA = "0x26473D0", Offset = "0x26473D0", VA = "0x26473D0")]
	private CircleStage GetCircleStage(int curIterationCounter)
	{
		return default(CircleStage);
	}

	[Token(Token = "0x600CAAE")]
	[Address(RVA = "0x26475E0", Offset = "0x26475E0", VA = "0x26475E0")]
	private void Iteration()
	{
	}

	[Token(Token = "0x600CAAF")]
	[Address(RVA = "0x26476F4", Offset = "0x26476F4", VA = "0x26476F4")]
	private float RateSample(int curIterationCounter)
	{
		return default(float);
	}

	[Token(Token = "0x600CAB0")]
	[Address(RVA = "0x26477E8", Offset = "0x26477E8", VA = "0x26477E8")]
	private float RateCelling(float rate)
	{
		return default(float);
	}

	[Token(Token = "0x600CAB1")]
	[Address(RVA = "0x2647804", Offset = "0x2647804", VA = "0x2647804")]
	private void Update()
	{
	}

	[Token(Token = "0x600CAB2")]
	[Address(RVA = "0x2647AC4", Offset = "0x2647AC4", VA = "0x2647AC4")]
	private void Text()
	{
	}
}
