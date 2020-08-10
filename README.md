# MvcCoreActionHiding
隐藏 asp net core action route

## 使用方式
### 1.在需要隐藏的控制器或方法上加入特性RouteHiding,如下例子：
    [RouteHiding]
    public class DemoController : ControllerBase
    {
    
    }
```

```
```
 services.AddControllersWithViews().AddRouteHiding(services);
```
