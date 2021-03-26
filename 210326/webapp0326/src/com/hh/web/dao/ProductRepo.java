package com.hh.web.dao;

import java.util.ArrayList;

import com.hh.web.dto.Product;

public class ProductRepo {
	private ArrayList<Product> listOfProducts = new ArrayList<Product>();

	public ProductRepo() {
		Product iphone = new Product("P1111", "IPhone12", 1000000);
		iphone.setDescription("6인치, 1334x750 Renina HD Display, " + "8-megapixel Camera");
		iphone.setCategory("스마트폰");
		iphone.setManufacturer("애플");
		iphone.setUnitInStock(1000);
		iphone.setCondition("2020년 출시");
		listOfProducts.add(iphone); // 리스트에 저장

		Product notebook = new Product("P1112", "LG 그램 2021", 2500000);
		notebook.setDescription("15인치, 2800x1850 OLED HD Display, " + "인텔i7 11세대, 메모리 DDR4");
		notebook.setCategory("노트북");
		notebook.setManufacturer("LG");
		notebook.setUnitInStock(1000);
		notebook.setCondition("2021년 출시");
		listOfProducts.add(notebook);

		Product tablet = new Product("P3111", "삼성 갤럭시탭S7", 400000);
		tablet.setDescription("10인치, 2000x1850 OLED HD Display, " + "메모리 128G");
		tablet.setCategory("태블릿");
		tablet.setManufacturer("삼성전자");
		tablet.setUnitInStock(1000);
		tablet.setCondition("2020년 출시");
		listOfProducts.add(tablet);
	}

	public ArrayList<Product> getAllProduct() {
		return listOfProducts;
	}

	public Product getProductById(String productId) { // String productId : jsp에서 넘어들어온 값
		Product productById = null;
		for (int i = 0; i < listOfProducts.size(); i++) {
			Product product = listOfProducts.get(i);
			if (product != null && product.getProductId() != null && product.getProductId().equals(productId)) {
				productById = product;
				break;
			}
		}
		return productById;
		// 제품의 정보 리턴
	}
}