using UnityEngine;

public class SVGGEllipse {
  private Vector2 _p;
  private float _r1, _r2, _angle;

  public Vector2 point {
    get { return this._p; }
  }

  public float r1 {
    get { return this._r1; }
  }

  public float r2 {
    get { return this._r2; }
  }

  public float angle {
    get { return this._angle; }
  }

  public SVGGEllipse(Vector2 p, float r1, float r2, float angle) {
    _p = p;
    _r1 = r1;
    _r2 = r2;
    _angle = angle;
  }
}
