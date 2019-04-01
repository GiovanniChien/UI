/*
 Navicat Premium Data Transfer

 Source Server         : localhost_3306
 Source Server Type    : MySQL
 Source Server Version : 80013
 Source Host           : localhost:3306
 Source Schema         : goodmanagesys

 Target Server Type    : MySQL
 Target Server Version : 80013
 File Encoding         : 65001

 Date: 28/02/2019 04:37:10
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

create database goodmanagesys;
use goodmanagesys;

-- ----------------------------
-- Table structure for category
-- ----------------------------
DROP TABLE IF EXISTS `category`;
CREATE TABLE `category`  (
  `categoryID` int(11) NOT NULL AUTO_INCREMENT,
  `categoryName` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `parentCategoryID` int(11) DEFAULT NULL,
  `parentCategoryName` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `unit` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `color` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `firm` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `minStock` int(11) DEFAULT NULL,
  `maxStock` int(11) DEFAULT NULL,
  `expirationDate` int(11) DEFAULT NULL,
  `isValid` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`categoryID`) USING BTREE,
  INDEX `categoryID`(`categoryID`) USING BTREE,
  INDEX `categoryID_2`(`categoryID`) USING BTREE,
  INDEX `categoryID_3`(`categoryID`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of category
-- ----------------------------
INSERT INTO `category` VALUES (19001, '统一冰红茶', 1, '饮料', '瓶', '澄', '统一', 12, 120, 6, 1);
INSERT INTO `category` VALUES (19002, '康师傅绿茶', 1, '饮料', '瓶', '绿', '康师傅', 12, 120, 12, 1);
INSERT INTO `category` VALUES (19003, '哇哈哈矿泉水', 1, '饮料', '瓶', '透明', '娃哈哈', 10, 100, 12, 1);
INSERT INTO `category` VALUES (19004, '太谷饼', 4, '糕饼', '袋', NULL, NULL, 5, 20, 12, 1);
INSERT INTO `category` VALUES (19005, '五粮液', 2, '酒', '瓶', '透明', '五粮液', 3, 12, 18, 1);
INSERT INTO `category` VALUES (19006, '中华', 3, '香烟', '盒', '红', '中华', 4, 20, 24, 1);
INSERT INTO `category` VALUES (19007, '真知棒棒棒糖', 5, '糖果', '根', NULL, '真知棒', 5, 100, 6, 1);
INSERT INTO `category` VALUES (19008, '蒙牛纯牛奶', 6, '奶制品', '盒', '白', '蒙牛', 3, 12, 3, 1);
INSERT INTO `category` VALUES (19009, '乐事薯片', 7, '休闲食品', '袋', NULL, '乐事', 5, 20, 6, 1);
INSERT INTO `category` VALUES (19010, '乐事薯片', 7, '休闲食品', '桶', NULL, '乐事', 5, 20, 6, 1);

-- ----------------------------
-- Table structure for good
-- ----------------------------
DROP TABLE IF EXISTS `good`;
CREATE TABLE `good`  (
  `goodID` int(11) NOT NULL AUTO_INCREMENT,
  `categoryID` int(11) DEFAULT NULL,
  `productionDate` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `purchaseDate` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `cost` double DEFAULT NULL,
  `price` double DEFAULT NULL,
  `isValid` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`goodID`) USING BTREE,
  INDEX `categoryID`(`categoryID`) USING BTREE,
  INDEX `goodID`(`goodID`) USING BTREE,
  CONSTRAINT `good_ibfk_1` FOREIGN KEY (`categoryID`) REFERENCES `category` (`categoryid`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of good
-- ----------------------------
INSERT INTO `good` VALUES (1001, 19001, '20190227', '20190228', 1, NULL, 1);
INSERT INTO `good` VALUES (1002, 19001, '20190227', '20190228', 1, 2.5, 0);
INSERT INTO `good` VALUES (1003, 19003, '20190219', '20190220', 3, NULL, 1);
INSERT INTO `good` VALUES (1004, 19003, '20190227', '20190228', 4, NULL, 1);
INSERT INTO `good` VALUES (1005, 19003, '20190219', '20190220', 3, 3.5, 0);
INSERT INTO `good` VALUES (1006, 19006, '20190219', '20190221', 10, NULL, 1);
INSERT INTO `good` VALUES (1007, 19008, '20190226', '20190228', 15, 20, 0);

-- ----------------------------
-- Table structure for membership
-- ----------------------------
DROP TABLE IF EXISTS `membership`;
CREATE TABLE `membership`  (
  `msID` int(11) NOT NULL AUTO_INCREMENT,
  `msName` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `msPhone` varchar(15) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `msPoint` int(11) DEFAULT NULL,
  `isValid` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`msID`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of membership
-- ----------------------------
INSERT INTO `membership` VALUES (29001, '张三', '13813813888', 80, 1);
INSERT INTO `membership` VALUES (29002, '王丽', '17312812931', 0, 1);
INSERT INTO `membership` VALUES (29003, '李帅', '15712132123', 90, 0);
INSERT INTO `membership` VALUES (29004, '赵武', '13912312389', 0, 0);
INSERT INTO `membership` VALUES (29005, '周山', '17912839472', 10, 1);

-- ----------------------------
-- Table structure for purchase
-- ----------------------------
DROP TABLE IF EXISTS `purchase`;
CREATE TABLE `purchase`  (
  `purchaseID` int(11) NOT NULL AUTO_INCREMENT,
  `categoryID` int(11) NOT NULL,
  `purchaseDate` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `quantity` int(11) DEFAULT NULL,
  `cost` double DEFAULT NULL,
  `staffID` int(11) DEFAULT NULL,
  PRIMARY KEY (`purchaseID`, `categoryID`) USING BTREE,
  INDEX `categoryID`(`categoryID`) USING BTREE,
  INDEX `staffID`(`staffID`) USING BTREE,
  CONSTRAINT `purchase_ibfk_1` FOREIGN KEY (`categoryID`) REFERENCES `category` (`categoryid`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `purchase_ibfk_2` FOREIGN KEY (`staffID`) REFERENCES `staff` (`staffid`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of purchase
-- ----------------------------
INSERT INTO `purchase` VALUES (22001, 19001, '20190228', 2, 2, 18004);
INSERT INTO `purchase` VALUES (22001, 19003, '20190228', 1, 4, 18004);
INSERT INTO `purchase` VALUES (22001, 19008, '20190228', 1, 15, 18004);
INSERT INTO `purchase` VALUES (22002, 19003, '20190220', 2, 6, 18005);
INSERT INTO `purchase` VALUES (22003, 19006, '20190221', 1, 10, 18005);

-- ----------------------------
-- Table structure for sale
-- ----------------------------
DROP TABLE IF EXISTS `sale`;
CREATE TABLE `sale`  (
  `saleID` int(11) NOT NULL AUTO_INCREMENT,
  `goodID` int(11) NOT NULL,
  `saleDate` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `profit` double DEFAULT NULL,
  `staffID` int(11) DEFAULT NULL,
  PRIMARY KEY (`saleID`, `goodID`) USING BTREE,
  INDEX `goodID`(`goodID`) USING BTREE,
  INDEX `staffID`(`staffID`) USING BTREE,
  CONSTRAINT `sale_ibfk_1` FOREIGN KEY (`goodID`) REFERENCES `good` (`goodid`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `sale_ibfk_2` FOREIGN KEY (`staffID`) REFERENCES `staff` (`staffid`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of sale
-- ----------------------------
INSERT INTO `sale` VALUES (6001, 1002, '20190301', 1.5, 18002);
INSERT INTO `sale` VALUES (6001, 1005, '20190301', 0.5, 18002);
INSERT INTO `sale` VALUES (6002, 1007, '20190302', 5, 18003);

-- ----------------------------
-- Table structure for staff
-- ----------------------------
DROP TABLE IF EXISTS `staff`;
CREATE TABLE `staff`  (
  `staffID` int(11) NOT NULL AUTO_INCREMENT,
  `staffName` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `pwd` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `staffPhone` varchar(15) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `role` int(11) DEFAULT NULL,
  PRIMARY KEY (`staffID`) USING BTREE,
  INDEX `staffID`(`staffID`) USING BTREE,
  INDEX `staffID_2`(`staffID`) USING BTREE,
  INDEX `staffID_3`(`staffID`) USING BTREE,
  INDEX `staffID_4`(`staffID`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of staff
-- ----------------------------
INSERT INTO `staff` VALUES (18001, '小王', '123456', '13813912389', 1);
INSERT INTO `staff` VALUES (18002, '小李', '1234', '18312398923', 2);
INSERT INTO `staff` VALUES (18003, '小白', '2345', '18943286543', 2);
INSERT INTO `staff` VALUES (18004, '小周', '3456', '17816734679', 3);
INSERT INTO `staff` VALUES (18005, '小赵', '12345678', '13413453246', 3);
INSERT INTO `staff` VALUES (18006, '小罗', '980203', '13978164738', 2);

SET FOREIGN_KEY_CHECKS = 1;
