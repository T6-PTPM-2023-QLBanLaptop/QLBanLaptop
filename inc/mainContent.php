<?php
$product = new Product();
$list = $product->getAll(0, 10);
?>

<div class="maincontent-area">
    <div class="zigzag-bottom"></div>
    <div class="container">
        <div class="row">
            <div class="col-md-12">
                <div class="latest-product">
                    <hr>
                    <h2 class="section-title">Sản phẩm mới nhất</h2>
                    <div class="product-carousel">
                        <?php
                        foreach ($list as $r) {
                            $listImg = $product->getImg($r['id']);

                        ?>
                            <div class="single-product">
                                <div class="product-f-image">
                                    <img src="<?php echo 'admin/product/uploads/' . $listImg[0]['img']; ?>" alt="<?php echo $r['name'] ?>">
                                    <div class="product-hover">
                                        <a href="?add-to-cart=<?php echo $r['id'] ?>" 
                                        class="add-to-cart-link"><i class="fa fa-shopping-cart"></i>Thêm vào giỏ</a>
                                    
                                    </div>
                                </div>

                                <h2><a href="single-product.php?product_id=<?php echo $r['id'] ?>"><?php echo $r['name'] ?></a></h2>

                                <div class="product-carousel-price">
                                    <ins><?php $sellprice = $r['price'] * (100 - $r['discount']) / 100;
                                            echo number_format($sellprice) ?></ins>
                                    <del><?php if ($sellprice != $r['price']) echo number_format($r['price']) ?></del>
                                </div>
                            </div>
                        <?php  } ?>

                    </div>
                </div>
                <hr>
                
                <?php include_once('inc/showProductByCate.php') ?>
            </div>

        </div>
    </div>
</div>