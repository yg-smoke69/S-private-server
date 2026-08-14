using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200336F")]
internal class UIUnBlockOtherHudScript : MonoBehaviour
{
	[Token(Token = "0x2003370")]
	private struct DepthEntry
	{
		[Token(Token = "0x401397B")]
		[FieldOffset(Offset = "0x0")]
		public int depth;

		[Token(Token = "0x401397C")]
		[FieldOffset(Offset = "0x4")]
		public RaycastHit hit;

		[Token(Token = "0x401397D")]
		[FieldOffset(Offset = "0x30")]
		public Vector3 point;

		[Token(Token = "0x401397E")]
		[FieldOffset(Offset = "0x3C")]
		public GameObject go;

		[Token(Token = "0x6015E01")]
		[Address(RVA = "0x866904", Offset = "0x866904", VA = "0x866904")]
		public bool IsVisible()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003371")]
	public delegate void OnClickEvent(List<GameObject> hitObjects);

	[Token(Token = "0x2003372")]
	public delegate void OnDragEvent(GameObject dragObject, Vector2 startPos);

	[Token(Token = "0x4013968")]
	[FieldOffset(Offset = "0xC")]
	private MouseOrTouch currentTouch;

	[Token(Token = "0x4013969")]
	[FieldOffset(Offset = "0x0")]
	public static int currentTouchID;

	[Token(Token = "0x401396A")]
	[FieldOffset(Offset = "0x4")]
	private static MouseOrTouch[] mMouse;

	[Token(Token = "0x401396B")]
	[FieldOffset(Offset = "0x8")]
	public static MouseOrTouch controller;

	[Token(Token = "0x401396C")]
	[FieldOffset(Offset = "0xC")]
	public static List<MouseOrTouch> activeTouches;

	[Token(Token = "0x401396D")]
	[FieldOffset(Offset = "0x10")]
	private static List<int> mTouchIDs;

	[Token(Token = "0x401396E")]
	[FieldOffset(Offset = "0x10")]
	private float mNextRaycast;

	[Token(Token = "0x401396F")]
	[FieldOffset(Offset = "0x14")]
	private static List<GameObject> mRayHitObjects;

	[Token(Token = "0x4013970")]
	[FieldOffset(Offset = "0x18")]
	private static GameObject mRayHitObject;

	[Token(Token = "0x4013971")]
	[FieldOffset(Offset = "0x1C")]
	private static GameObject fallThrough;

	[Token(Token = "0x4013972")]
	[FieldOffset(Offset = "0x20")]
	private static DepthEntry mHit;

	[Token(Token = "0x4013973")]
	[FieldOffset(Offset = "0x60")]
	private static BetterList<DepthEntry> mHits;

	[Token(Token = "0x4013974")]
	[FieldOffset(Offset = "0x14")]
	public float mouseDragThreshold;

	[Token(Token = "0x4013975")]
	[FieldOffset(Offset = "0x18")]
	public float mouseClickThreshold;

	[Token(Token = "0x4013976")]
	[FieldOffset(Offset = "0x1C")]
	public float touchDragThreshold;

	[Token(Token = "0x4013977")]
	[FieldOffset(Offset = "0x20")]
	public float touchClickThreshold;

	[Token(Token = "0x4013978")]
	[FieldOffset(Offset = "0x24")]
	public OnClickEvent OnClick;

	[Token(Token = "0x4013979")]
	[FieldOffset(Offset = "0x28")]
	public OnDragEvent OnDrag;

	[Token(Token = "0x401397A")]
	[FieldOffset(Offset = "0x64")]
	private static CompareFunc<DepthEntry> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x6015DED")]
	[Address(RVA = "0xF4CB08", Offset = "0xF4CB08", VA = "0xF4CB08")]
	public UIUnBlockOtherHudScript()
	{
	}

	[Token(Token = "0x6015DEE")]
	[Address(RVA = "0xF4CB30", Offset = "0xF4CB30", VA = "0xF4CB30")]
	private void Awake()
	{
	}

	[Token(Token = "0x6015DEF")]
	[Address(RVA = "0xF4CE94", Offset = "0xF4CE94", VA = "0xF4CE94")]
	private void Start()
	{
	}

	[Token(Token = "0x6015DF0")]
	[Address(RVA = "0xF4D0B4", Offset = "0xF4D0B4", VA = "0xF4D0B4")]
	private void Update()
	{
	}

	[Token(Token = "0x6015DF1")]
	[Address(RVA = "0xF4D4C4", Offset = "0xF4D4C4", VA = "0xF4D4C4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6015DF2")]
	[Address(RVA = "0xF4D7E8", Offset = "0xF4D7E8", VA = "0xF4D7E8")]
	public void ProcessMouse()
	{
	}

	[Token(Token = "0x6015DF3")]
	[Address(RVA = "0xF4D114", Offset = "0xF4D114", VA = "0xF4D114")]
	public void ProcessTouches()
	{
	}

	[Token(Token = "0x6015DF4")]
	[Address(RVA = "0xF4EB6C", Offset = "0xF4EB6C", VA = "0xF4EB6C")]
	private void ProcessFakeTouches()
	{
	}

	[Token(Token = "0x6015DF5")]
	[Address(RVA = "0xF4E530", Offset = "0xF4E530", VA = "0xF4E530")]
	public MouseOrTouch GetTouch(int id, bool createIfMissing)
	{
		return null;
	}

	[Token(Token = "0x6015DF6")]
	[Address(RVA = "0xF4E908", Offset = "0xF4E908", VA = "0xF4E908")]
	public void RemoveTouch(int id)
	{
	}

	[Token(Token = "0x6015DF7")]
	[Address(RVA = "0xF4E374", Offset = "0xF4E374", VA = "0xF4E374")]
	public void ProcessTouch(bool pressed, bool released, bool isMouse)
	{
	}

	[Token(Token = "0x6015DF8")]
	[Address(RVA = "0xF4F158", Offset = "0xF4F158", VA = "0xF4F158")]
	private void ProcessPress(bool pressed, float click, float drag)
	{
	}

	[Token(Token = "0x6015DF9")]
	[Address(RVA = "0xF4EF50", Offset = "0xF4EF50", VA = "0xF4EF50")]
	private void ProcessRelease(bool isMouse, float drag)
	{
	}

	[Token(Token = "0x6015DFA")]
	[Address(RVA = "0xF4E158", Offset = "0xF4E158", VA = "0xF4E158")]
	public static void Raycast(MouseOrTouch touch)
	{
	}

	[Token(Token = "0x6015DFB")]
	[Address(RVA = "0xF50640", Offset = "0xF50640", VA = "0xF50640")]
	public static bool Raycast(Vector3 inPos, out GameObject hitObject)
	{
		return default(bool);
	}

	[Token(Token = "0x6015DFC")]
	[Address(RVA = "0xF4F83C", Offset = "0xF4F83C", VA = "0xF4F83C")]
	public static bool Raycast(Vector3 inPos)
	{
		return default(bool);
	}

	[Token(Token = "0x6015DFD")]
	[Address(RVA = "0xF4F74C", Offset = "0xF4F74C", VA = "0xF4F74C")]
	public void OnClickNotified()
	{
	}

	[Token(Token = "0x6015DFE")]
	[Address(RVA = "0xF4F690", Offset = "0xF4F690", VA = "0xF4F690")]
	public void OnDragNotified()
	{
	}

	[Token(Token = "0x6015E00")]
	[Address(RVA = "0xF514AC", Offset = "0xF514AC", VA = "0xF514AC")]
	private static int _003CRaycast_003Em__0(DepthEntry r1, DepthEntry r2)
	{
		return default(int);
	}
}
